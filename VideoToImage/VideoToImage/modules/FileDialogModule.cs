using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoToImage.modules
{
    class FileDialogModule
    {
        /// <summary>
        /// 파일 다이얼로그를 열고 선택한 동영상의 주소를 반환.
        /// </summary>
        /// <returns> 선택한 이미지의 주소 배열 반환, 오류시 null 반환 </returns>
        public List<FileInfo> getLocalVideoPath()
        {
            List<FileInfo> fileInfo = new List<FileInfo>();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 초기 경로 설정
            openFileDialog.InitialDirectory = @"d:\";
            // 파일 양식 설정
            openFileDialog.Filter = "Video Files | *.mp4";
            openFileDialog.Multiselect = true; //여러파일선택

            // 파일 및 경로가 존재하는지 확인
            openFileDialog.CheckFileExists = true;

            // 파일을 가져왔는지 체크
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return null;

            try
            {
                int fileCount = 0;
                // mp4 파일을 가져왔는지 체크
                foreach (string tempFileName in openFileDialog.FileNames)
                {
                    fileInfo.Add(new FileInfo(tempFileName));

                    if (!fileInfo[fileCount].Extension.Equals(".mp4"))
                    {
                        MessageBox.Show("동영상 파일을 다시 확인하세요.");
                        return null;
                    }
                    fileCount++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("동영상 파일을 다시 확인하세요.");
                return null;
            }
            return fileInfo;
        }

        /// <summary>
        /// 파일 다이얼로그를 열고 선택한 동영상의 주소를 반환.
        /// </summary>
        /// <returns> 선택한 이미지의 주소 배열 반환, 오류시 null 반환 </returns>
        public List<FileInfo> getVideoPathInFolder(string basePath)
        {
            List<FileInfo> fileInfo = new List<FileInfo>();
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();

            openFileDialog.SelectedPath = basePath;

            // 파일을 가져왔는지 체크
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return null;

            try
            {
                // mp4 파일을 가져왔는지 체크
                foreach (string tempFileName in Directory.GetFiles(openFileDialog.SelectedPath))
                {
                    FileInfo tempFile = new FileInfo(tempFileName);
                    if (!tempFile.Extension.Equals(".mp4")) continue;

                    fileInfo.Add(tempFile);
                }
                if (fileInfo.Count <= 0) return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("동영상 파일을 다시 확인하세요.");
                return null;
            }
            return fileInfo;
        }

        public List<FileInfo> convertFileName(List<FileInfo> oldFileInfoList, String convertChar, String resultConverChar)
        {
            List<FileInfo> resultFileInfoList = new List<FileInfo>();

            foreach (FileInfo oldFileInfo in oldFileInfoList)
            {
                if (System.IO.File.Exists(oldFileInfo.FullName))
                {
                    String tempName = "";
                    String[] newTempName = oldFileInfo.Name.Split('.');
                    for (int i = 0; i < newTempName.Length - 1; i++)
                    {
                        tempName += newTempName[i];
                        if (i < newTempName.Length - 2) tempName += ".";
                    }

                    String newFileName = tempName.Replace(convertChar, resultConverChar);
                    System.IO.File.Move(oldFileInfo.FullName, oldFileInfo.DirectoryName + "\\" + newFileName + oldFileInfo.Extension);

                    resultFileInfoList.Add(new FileInfo(oldFileInfo.DirectoryName + "\\" + newFileName + oldFileInfo.Extension));
                }
            }

            return resultFileInfoList;
        }

        public List<FileInfo> convertfolderInFileName(DirectoryInfo oldFilePath, String convertChar, String resultConverChar)
        {
            List<FileInfo> resultFileInfoList = new List<FileInfo>();
            List<FileInfo> oldFileInfoList = new List<FileInfo>();

            if (oldFilePath.Exists)
            {
                foreach (string tempFileName in Directory.GetFiles(oldFilePath.FullName))
                {
                    FileInfo tempFile = new FileInfo(tempFileName);
                    if (tempFile.Extension.Equals(".txt")) continue;

                    oldFileInfoList.Add(tempFile);
                }

            }

            return convertFileName(oldFileInfoList, convertChar, resultConverChar);
        }

    }
}
