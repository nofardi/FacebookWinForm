using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class CommonIntroFinder : ICommonFinders
    {
        private StringBuilder m_IntroStr = new StringBuilder();

        public void FindCommon(User i_FirstUser, User i_SecUser)
        {
            m_IntroStr.AppendLine(this.getCommonBirthday(i_FirstUser, i_SecUser));
            m_IntroStr.AppendLine(this.getCommonHometown(i_FirstUser, i_SecUser));
            m_IntroStr.AppendLine(this.getCommonLocation(i_FirstUser, i_SecUser));
            m_IntroStr.AppendLine(this.getCommonRelationStatus(i_FirstUser, i_SecUser));
            m_IntroStr.AppendLine(this.getCommonBirthday(i_FirstUser, i_SecUser));
            m_IntroStr.AppendLine(this.getCommonEducation(i_FirstUser, i_SecUser));
        }

        private string getCommonBirthday(User i_FirstUser, User i_SecUser)
        {
            string birthStr = string.Empty;
            string introStr = "Both Studied at";
            if (i_FirstUser.Birthday != null && i_SecUser.Birthday != null)
            {
                if (i_FirstUser.Birthday.Equals(i_SecUser.Birthday))
                {
                    birthStr = i_FirstUser.Birthday;
                }
                else if (DateTime.Parse(i_FirstUser.Birthday).Year == DateTime.Parse(i_SecUser.Birthday).Year)
                {
                    birthStr = DateTime.Parse(i_FirstUser.Birthday).Year.ToString();
                }
                else if (DateTime.Parse(i_FirstUser.Birthday).Month == DateTime.Parse(i_SecUser.Birthday).Month)
                {
                    birthStr = DateTime.Parse(i_FirstUser.Birthday).Month.ToString();
                }
                else if (DateTime.Parse(i_FirstUser.Birthday).Day == DateTime.Parse(i_SecUser.Birthday).Day)
                {
                    birthStr = DateTime.Parse(i_FirstUser.Birthday).Day.ToString();
                }
            }

            if (!string.IsNullOrEmpty(birthStr))
            {
                birthStr = string.Format("{0} {1}", introStr, birthStr);
            }

            return birthStr;
        }

        private string getCommonRelationStatus(User i_FirstUser, User i_SecUser)
        {
            string status = string.Empty;
            string introStr = "Both are";
            if (i_FirstUser.RelationshipStatus != null && i_SecUser.RelationshipStatus != null)
            {
                if (i_FirstUser.RelationshipStatus.Value.Equals(i_SecUser.RelationshipStatus.Value))
                {
                    status = i_FirstUser.RelationshipStatus.Value.ToString();
                }
            }

            if (!string.IsNullOrEmpty(status))
            {
                status = string.Format("{0} {1}", introStr, status);
            }

            return status;
        }

        private string getCommonLocation(User i_FirstUser, User i_SecUser)
        {
            string introStr = "Both live now in";
            string location = string.Empty;
            if (i_FirstUser.Location != null && i_SecUser.Location != null)
            {
                if (i_FirstUser.Location.Id == i_SecUser.Location.Id)
                {
                    location = i_FirstUser.Location.Name.ToString();
                }
            }

            if (!string.IsNullOrEmpty(location))
            {
                location = string.Format("{0} {1}", introStr, location);
            }

            return location;
        }

        private string getCommonHometown(User i_FirstUser, User i_SecUser)
        {
            string hometown = string.Empty;
            string introStr = "Both grew up in";
            if (i_FirstUser.Hometown != null && i_SecUser.Hometown != null)
            {
                if (i_FirstUser.Hometown.Id == i_SecUser.Hometown.Id)
                {
                    hometown = i_FirstUser.Hometown.Name.ToString();
                }
            }

            if (!string.IsNullOrEmpty(hometown))
            {
                hometown = string.Format("{0} {1}", introStr, hometown);
            }

            return hometown;
        }

        private string getCommonEducation(User i_FirstUser, User i_SecUser)
        {
            string education = string.Empty;
            string introStr = "Both study at:";
            if (i_FirstUser.Educations != null && i_SecUser.Educations != null)
            {
                if (i_FirstUser.Educations[0].School.Id == i_SecUser.Educations[0].School.Id)
                {
                    education = i_FirstUser.Educations[0].School.Name;
                }
            }

            if (!string.IsNullOrEmpty(education))
            {
                education = string.Format("{0} {1}", introStr, education);
            }

            return education;
        }

        public void SetProp(CommonProp i_CommonProp)
        {
            i_CommonProp.IntroInCommon = m_IntroStr.ToString();
        }
    }
}
