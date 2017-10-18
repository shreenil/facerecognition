using Microsoft.ProjectOxford.Common.Contract;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace AzureFaceRecognition
{

    // Console di verifica
    // https://dev.projectoxford.ai/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395236/console

    public partial class Form1 : Form
    {
        private readonly IFaceServiceClient faceServiceClient = new FaceServiceClient("c9dad05412cd48a1bd036a4f06c841f1", "https://westcentralus.api.cognitive.microsoft.com/face/v1.0");

        string _imagePath = "";
        string _groupId   = "";

        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap resizeAndSaveImage(Bitmap image, int quality, string filePath)
        {
            int maxWidth = 640;
            int maxHeight = 360;
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            // Get an ImageCodecInfo object that represents the JPEG codec.
            ImageCodecInfo imageCodecInfo = this.GetEncoderInfo(ImageFormat.Jpeg);

            // Create an Encoder object for the Quality parameter.
            Encoder encoder = Encoder.Quality;

            // Create an EncoderParameters object. 
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;
            newImage.Save(filePath, imageCodecInfo, encoderParameters);
            return newImage;
        }
        public Bitmap resizeImage(Bitmap image, int quality, string filePath)
        {
            int maxWidth = 640;
            int maxHeight = 360;
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            // Get an ImageCodecInfo object that represents the JPEG codec.
            ImageCodecInfo imageCodecInfo = this.GetEncoderInfo(ImageFormat.Jpeg);

            // Create an Encoder object for the Quality parameter.
            Encoder encoder = Encoder.Quality;

            // Create an EncoderParameters object. 
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;
            //newImage.Save(filePath, imageCodecInfo, encoderParameters);
            return newImage;
        }

        /// <summary>
        /// Method to get encoder infor for given image format.
        /// </summary>
        /// <param name="format">Image format</param>
        /// <returns>image codec info.</returns>
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

        /// <summary>
        /// Main task, which connects to the Azure Face Services to upload the image and retrieve informations
        /// </summary>
        /// <param name="imageFilePath"></param>
        /// <returns></returns>
        private async Task<Face[]> UploadAndDetectFaces(string imageFilePath)
        {
            try
            {
                using (Stream imageFileStream = File.OpenRead(imageFilePath))
                {
                    var faces = await faceServiceClient.DetectAsync(imageFileStream, 
                        true, 
                        true, 
                        new FaceAttributeType[] {
                            FaceAttributeType.Gender,
                            FaceAttributeType.Age,
                            FaceAttributeType.Emotion
                        });
                    return faces.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new Face[0];
            }
        }

        /// <summary>
        /// Search for an image and load it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (txt_reg.Text == "")
            {
                MessageBox.Show("Please enter username");
                txt_reg.Focus();
                return;
            }
            idList.Items.Clear();
            listUsers.Items.Clear();
            txtGroupName.Text = "";
            txtNewUser.Text = "";

            using (var od = new OpenFileDialog())
            {
                od.Filter = "All files(*.*)|*.*";
                if (od.ShowDialog() == DialogResult.OK)
                {
                    _imagePath = od.FileName;
                    //imgBox.Load(_imagePath);

                    
                    string mainPath = Application.StartupPath + "\\imagestemp";
                    string i2path = mainPath + "\\temp" + ".jpg";
                    if (!Directory.Exists(mainPath))
                    {
                        //Directory.Delete()
                        Directory.CreateDirectory(mainPath);
                    }
                    Bitmap img = resizeAndSaveImage(new Bitmap(od.FileName), 100, i2path);
                    imgBox.Image = img;
                    _imagePath = i2path;
                    
                    //btnProcess_Click(new object(), new EventArgs());
                    txtGroupName.Text = txt_reg.Text;
                    txtNewUser.Text = txt_reg.Text;
                    string groupPath = Application.StartupPath + "\\images";
                    txtImageFolder.Text = groupPath;
                    //btnAddUser_Click(new object(), new EventArgs());
                    //btnCreateGroup_Click(new object(), new EventArgs());
                    //btnTrain_Click(new object(), new EventArgs());
                    //btnIdentify_Click(new object(), new EventArgs());
                }
            }
        }

        // Return a Rectangle (used for drawing landmarks)
        private Rectangle GetRectangle(FeatureCoordinate fl)
        {
            return new Rectangle((int)fl.X - 1, (int)fl.Y - 1, 2, 2);
        }

        
        /// <summary>
        /// Faces processing (retrieve informations from Azure and draw accordingly)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnProcess_Click(object sender, EventArgs e)
        {
            if (txt_reg.Text == "")
            {
                MessageBox.Show("Please enter your username");
                return;
            }
            if (imgBox.Image == null)
            {
                MessageBox.Show("Please Browse the image first!");
                return;
            }
            
            progressBar1.Visible = true;
            Face[] faces = await UploadAndDetectFaces(_imagePath);

            if (faces.Length > 0)
            {
                var faceBitmap = new Bitmap(imgBox.Image);

                using (var g = Graphics.FromImage(faceBitmap))
                {
                    // Alpha-black rectangle on entire image
                    g.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 0, 0)), g.ClipBounds);

                    var br = new SolidBrush(Color.FromArgb(200, Color.LightGreen));

                    // Loop each face recognized
                    foreach (var face in faces)
                    {
                        var fr = face.FaceRectangle;
                        var fa = face.FaceAttributes;

                        // Get original face image (color) to overlap the grayed image
                        var faceRect = new Rectangle(fr.Left, fr.Top, fr.Width, fr.Height);
                        g.DrawImage(imgBox.Image, faceRect, faceRect, GraphicsUnit.Pixel);
                        g.DrawRectangle(Pens.LightGreen, faceRect);

                        // Loop face.FaceLandmarks properties for drawing landmark spots
                        var pts = new List<Point>();
                        Type type = face.FaceLandmarks.GetType();
                        foreach (PropertyInfo property in type.GetProperties())
                        {
                            g.DrawRectangle(Pens.LightGreen, GetRectangle((FeatureCoordinate)property.GetValue(face.FaceLandmarks, null)));
                        }

                        // Calculate where to position the detail rectangle
                        int rectTop = fr.Top + fr.Height + 10;
                        if (rectTop + 45 > faceBitmap.Height) rectTop = fr.Top - 30;

                        // Draw detail rectangle and write face informations                      
                        g.FillRectangle(br, fr.Left - 10, rectTop, fr.Width < 120 ? 120 : fr.Width + 20, 25);
                        g.DrawString(string.Format("{0:0.0} / {1} / {2}", fa.Age, fa.Gender, fa.Emotion.ToRankedList().OrderByDescending(x => x.Value).First().Key), 
                                     this.Font, Brushes.Black, 
                                     fr.Left - 12, 
                                     rectTop + 8);
                        btnAddUser_Click(new object(), new EventArgs());
                    }
                }

                imgBox.Image = faceBitmap;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Browse and choose a folder with personal images in it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPBrowse_Click(object sender, EventArgs e)
        {
            using (var fb = new FolderBrowserDialog())
            {
                if (fb.ShowDialog() == DialogResult.OK)
                    txtImageFolder.Text = fb.SelectedPath;
                else
                    txtImageFolder.Text = "";
            }
        }

        /// <summary>
        /// Add a new user to the users list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text == "") return;
            listUsers.Items.Add(txtNewUser.Text);
            btnCreateGroup_Click(new object(), new EventArgs());
            
        }

        /// <summary>
        /// Create a new PersonGroup, then proceed to send pictures of each listed user, uploading them from given directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnCreateGroup_Click(object sender, EventArgs e)
        {
            try
            {
                _groupId = txtGroupName.Text.ToLower().Replace(" ", "");

                try
                {
                    await faceServiceClient.DeletePersonGroupAsync(_groupId);
                } catch { }

                await faceServiceClient.CreatePersonGroupAsync(_groupId, txtGroupName.Text); 

                foreach (var u in listUsers.Items)
                {
                    CreatePersonResult person = await faceServiceClient.CreatePersonAsync(_groupId, u.ToString());
                    foreach (string imagePath in Directory.GetFiles(txtImageFolder.Text + "\\" + u.ToString()))
                    {
                        using (Stream s = File.OpenRead(imagePath))
                        {
                            await faceServiceClient.AddPersonFaceAsync(_groupId, person.PersonId, s);
                        }
                    }

                    await Task.Delay(1000);
                }
                btnTrain_Click(new object(), new EventArgs());
               // MessageBox.Show("Group successfully created");
            } catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                btnTrain_Click(new object(), new EventArgs());
            }
        }

        /// <summary>
        /// Trains the group, using the provided images to increase precision in associating a face to a name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnTrain_Click(object sender, EventArgs e)
        {
            try
            {
                await faceServiceClient.TrainPersonGroupAsync(_groupId);

                TrainingStatus trainingStatus = null;
                while (true)
                {
                    trainingStatus = await faceServiceClient.GetPersonGroupTrainingStatusAsync(_groupId);

                    if (trainingStatus.Status != Status.Running)
                    {
                        break;
                    }

                    await Task.Delay(1000);
                }
                btnIdentify_Click(new object(), new EventArgs());
               // MessageBox.Show("Training successfully completed");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Use the training data to spot individuals on a provided image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnIdentify_Click(object sender, EventArgs e)
        {
            try
            {
                Face[] faces = await UploadAndDetectFaces(_imagePath);
                var faceIds = faces.Select(face => face.FaceId).ToArray();

                var faceBitmap = new Bitmap(imgBox.Image);
                idList.Items.Clear();

                using (var g = Graphics.FromImage(faceBitmap))
                {

                    foreach (var identifyResult in await faceServiceClient.IdentifyAsync(_groupId, faceIds))
                    {
                        if (identifyResult.Candidates.Length != 0)
                        {
                            var candidateId = identifyResult.Candidates[0].PersonId;
                            var person = await faceServiceClient.GetPersonAsync(_groupId, candidateId);

                            // Writes name above face rectangle
                            var x = faces.FirstOrDefault(y => y.FaceId == identifyResult.FaceId);
                            if (x != null)
                            {
                                g.DrawString(person.Name, this.Font, Brushes.White, x.FaceRectangle.Left, x.FaceRectangle.Top + x.FaceRectangle.Height + 15);
                            }

                            idList.Items.Add(person.Name);
                        }
                        else
                        {
                            idList.Items.Add("< Unknown person >");
                        }

                    }
                }

                imgBox.Image = faceBitmap;
                progressBar1.Visible = false;
                if (idList.FindString(txt_reg.Text) >= 0)
                {
                    MessageBox.Show("Welcome, "+txt_reg.Text);
                }
                else
                {
                    MessageBox.Show("Sorry! I Don't know you, please try again!");
                }
               

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int reg_cnt=1;
        private void register_btn_Click(object sender, EventArgs e)
        {
            string path="";
            if (txt_reg.Text == "")
            {
                MessageBox.Show("Please Enter Registration username");
                txt_reg.Focus();
            }
            else
            {
                using (var od = new OpenFileDialog())
                {
                    od.Filter = "All files(*.*)|*.*";
                    if (od.ShowDialog() == DialogResult.OK)
                    {
                        path = od.FileName;
                        //imgBox.Load(_imagePath);
                        string mainPath = Application.StartupPath + "\\images";
                        if (!Directory.Exists(mainPath))
                        {
                            //Directory.Delete()
                            Directory.CreateDirectory(mainPath);
                        }
                        string dirPath = mainPath + "\\" + txt_reg.Text;
                        if (!Directory.Exists(dirPath))
                        {
                            //Directory.Delete()
                            Directory.CreateDirectory(dirPath);
                        }
                        string i2path = dirPath + "\\" + txt_reg.Text + reg_cnt + ".jpg";
                        Bitmap img = resizeAndSaveImage(new Bitmap(od.FileName), 100, i2path);
                        imgBox.Image = img;
                        
                        //MessageBox.Show(i2path);
                        //var i = Image.FromFile(path);
                        //var i2 = new Bitmap(i);
                        //img.Save(i2path,ImageFormat.Jpeg);
                        reg_cnt++;
                        register_btn.Text = "Register Image " + reg_cnt;
                    }
                }
            }
        }

        private void reg_label_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void imgBox_Click(object sender, EventArgs e)
        {

        }
    }
}
