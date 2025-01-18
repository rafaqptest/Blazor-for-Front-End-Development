public class AttendanceService
{
    private readonly List<AttendanceModel> attendances = new List<AttendanceModel>();

    public void RegisterAttendance(int eventId, int userId, string userName, string userEmail)
    {
        attendances.Add(new AttendanceModel
        {
            EventId = eventId,
            UserId = userId,
            UserName = userName,
            UserEmail = userEmail,
            RegistrationDate = DateTime.Now
        });
    }

    public List<AttendanceModel> GetEventAttendance(int eventId)
    {
        return attendances.Where(a => a.EventId == eventId).ToList();
    }
}
