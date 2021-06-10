using NumberCrunch.Business.DataModels;

namespace NumberCrunch.Business
{
    public interface ICrunchLogic
    {
        ScoreDataModel CrunchNumbers(CrunchDataModel inputData);

    }
}
