using System;
using System.Collections.Generic;
using NumberCrunch.Business.DataModels;

namespace NumberCrunch.Business
{
    public class CrunchLogic : ICrunchLogic
    {
        public ScoreDataModel CrunchNumbers(CrunchDataModel inputData)
        {
            var result=new ScoreDataModel();
            var scoreDataList=new List<ScoreData>();
            for (int i = 1; i <= inputData.SampleMaxCnt; i++)
            {
                var scoreData=new ScoreData();
                scoreData.SampleNo = i;
                if ((i % inputData.PatientScore == 0) && (i % inputData.DocScore == 0))
                {
                    scoreData.Score=Scores.Both;
                }
                else if (i % inputData.PatientScore == 0)
                {
                    scoreData.Score = Scores.Patient;
                }
                else if (i % inputData.DocScore == 0)
                {
                    scoreData.Score = Scores.Doctor;
                }
                else
                {
                    scoreData.Score = Scores.None;
                }

                scoreDataList.Add(scoreData);
            }

            result.ScoreData = scoreDataList;
            result.MyMsg = inputData.UploadMsg;

            return result;
        }
    }
}
