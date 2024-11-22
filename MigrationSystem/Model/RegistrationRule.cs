namespace MigrationSystem.Model
{
    public class RegistrationRule: IRule
    {
        private DateTime deadlineDate;
        public bool Check(User user)
        {
            return user.Citizenship != null;
        }

        public RoadMapPoint CreateRoadMapPoint(User user)
        {
            int deadline = CalculateDeadline(user);
            deadlineDate = user.EntryDate.AddDays(deadline);
            RoadMapPoint roadMapPoint = new RoadMapPoint("Документ, подтверждающий постановку на миграционный учет по месту пребывания \r\n", "Вам необходимо обратиться к лицу, у которого проживаете, для того чтобы собственник помещения направил уведомление в УМВД через портал государственных услуг о постановке на миграционный учет иностранного гражданина по месту пребывания\r\n", $"{deadlineDate.ToString("dd.MM.yyyy")} ({deadline} дней)");
            return roadMapPoint;
        }

        private int CalculateDeadline(User user)
        {
            if ((user.IsHighQualified && user.WasMigrant) || user.Citizenship == "Киргизия" ||
                user.Citizenship == "Казахстан" || user.Citizenship == "Армения")
            {
                return 30;
            }
            else if (user.IsInProgram)
            {
                return 30;
            }
            else if (user.IsHighQualified || user.Citizenship == "Белоруссия" || user.Citizenship == "Украина")
            {
                return 90;
            }
            else if (user.Citizenship == "Таджикистан" || user.Citizenship == "Узбекистан")
            {
                return 15;
            }
            else
            {
                return 7;
            }
        }
    }
}
