/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
/*20Feb2014 T.PRAVEEN Added Post deployment script*/
/*12Mar2014 N.SARAVANAN Added static data for state table.*/
/*Saravanan N - 28th Mar, 2014 - Issues corrected in Script */
/*Bala - 14th May, 2014 - Issues corrected related personalInfo in Script */
/*Vincent-16 May,2014 - Made a changes in BR3 for wages*/
/* Removed query to insert Foreign as state name in state*/
/* Vincent-28 May,2014- added a changes in Topic for interest income */
/*Vivek -21-May-2014 - script for sign in issue has been added for user name and password same*/
/*Vincent-2Jun2014 2014-worked on Other income error message*/
/*05Jun2014 Thileep Added Email Template for Invoice in Efile Section*/
/*16Jun2014 Thileep Password Reset Link / Login link changes done in email template*/
/*17Jun2014 Thileep Changed error messages in wages Section*/
/*19Jun2014 Thileep Changed error messages in wages Section for error code Wages_ER8*/

INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('AL','Alabama')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('AK','Alaska')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('AZ','Arizona')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('AR','Arkansas')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('CA','California')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('CO','Colorado')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('CT','Connecticut')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('DE','Delaware')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('DC','District of Columbia')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('FL','Florida')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('GA','Georgia')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('HI','Hawaii')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('ID','Idaho')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('IL','Illinois')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('IN','Indiana')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('IA','Iowa')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('KS','Kansas')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('KY','Kentucky')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('LA','Louisiana')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('ME','Maine')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('MD','Maryland')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('MA','Massachusetts')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('MI','Michigan')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('MN','Minnesota')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('MS','Mississippi')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('MO','Missouri')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('MT','Montana')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('NE','Nebraska')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('NV','Nevada')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('NH','New Hampshire')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('NJ','New Jersey')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('NM','New Mexico')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('NY','New York')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('NC','North Carolina')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('ND','North Dakota')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('OH','Ohio')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('OK','Oklahoma')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('OR','Oregon')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('PA','Pennsylvania')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('RI','Rhode Island')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('SC','South Carolina')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('SD','South Dakota')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('TN','Tennessee')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('TX','Texas')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('UT','Utah')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('VT','Vermont')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('VA','Virginia')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('WA','Washington')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('WV','West Virginia')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('WI','Wisconsin')
INSERT INTO [dbo].[state] ([state_code], [state_name]) VALUES ('WY','Wyoming')


INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('AA','Armed Forces Americas  (except Canada)',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('AE','Armed Forces Africa ',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('AE','Armed Forces Canada',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('AE','Armed Forces Europe',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('AE','Armed Forces Middle East',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('AP','Armed Forces Pacific',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('AS','American Samoa',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('FM','Federated States of Micronesia',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('GU','Guam',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('MH','Marshall Islands',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('MP','Northern Mariana Islands',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('MT','Montana',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('PR','Puerto Rico',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('PW','Palau',1)
INSERT INTO [dbo].[state] ([state_code], [state_name],[is_additional_mailing_address]) VALUES ('VI','Virgin Islands',1)



GO

/*12Mar2014 N.SARAVANAN Added static data for country table.*/
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('USA','United States of America')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AF','Afghanistan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AX','Akrotiri')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AL','Albania')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AG','Algeria')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AQ','American Samoa')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AN','Andorra')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AO','Angola')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AV','Anguillia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AY','Antarctica')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AC','Antigua & Barbuda')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AR','Argentina')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AM','Armenia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AA','Aruba')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AT','Ashmore & Cartier Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AS','Australia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AU','Austria')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AJ','Azerbaijan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BF','Bahamas')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BA','Bahrain')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FQ','Baker Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BG','Bangladesh')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BB','Barbados')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BO','Belarus')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BE','Belgium')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BH','Belize')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BN','Benin')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BD','Bermuda')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BT','Bhutan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BL','Bolivia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BK','Bosnia-Herzegovina')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BC','Botswana')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BV','Bouvet Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BR','Brazil')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IO','British Indian Ocean Territory')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('VI','British Virgin Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BX','Brunei')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BU','Bulgaria')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('UV','Burkina Faso')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BM','Burma')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BY','Burundi')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CB','Cambodia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CM','Cameroon')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CA','Canada')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CV','Cape Verde')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CJ','Cayman Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GH','Ghana')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GI','Gibraltar')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GR','Greece')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GL','Greenland')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GJ','Grenada')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GQ','Guam')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GT','Guatemala')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GK','Guernsey')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GV','Guinea')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PU','Guinea-Bissau')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GY','Guyana')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('HA','Haiti')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('HM','Heard Island and McDonald Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('VT','Holy See')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('HO','Honduras')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('HK','Hong Kong')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('HQ','Howland Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('HU','Hungary')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IC','Iceland')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IN','India')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('ID','Indonesia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IR','Iran')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IZ','Iraq')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('EI','Ireland')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IS','Israel')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IT','Italy')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('JM','Jamaica')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('JN','Jan Mayen')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('JA','Japan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('DQ','Jarvis Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('JE','Jersey')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('JQ','Johnston Atoll')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('JO','Jordan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KZ','Kazakhstan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KE','Kenya')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KQ','Kingman Reef')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KR','Kiribati')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KN','"Korea')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KS','"Korea')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KV','Kosovo')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KU','Kuwait')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KG','Kyrgyzstan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LA','Laos')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NO','Norway')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MU','Oman')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('OC','Other Country')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PK','Pakistan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PS','Palau')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LQ','Palmyra Atoll')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PM','Panama')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PP','Papua-New Guinea')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PF','Paracel Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PA','Paraguay')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PE','Peru')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('RP','Philippines')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PC','Pitcairn Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PL','Poland')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PO','Portugal')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('RQ','Puerto Rico')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('QA','Qatar')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('RO','Romania')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('RS','Russia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('RW','Rwanda')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TB','Saint Barthelemy')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('RN','Saint Martin')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('WS','Samoa')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SM','San Marino')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TP','Sao Tome and Principe')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SA','Saudi Arabia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SG','Senegal')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('RI','Serbia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SE','Seychelles')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SL','Sierra Leone')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SN','Singapore')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NN','Sint Maarten')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LO','Slovakia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SI','Slovenia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BP','Solomon Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SO','Somalia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SF','South Africa')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SX','South Georgia and the South Sandwich Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('OD','South Sudan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SP','Spain')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('PG','Spratly Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SH','St. Helena')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CT','Central African Republic')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CD','Chad')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CI','Chile')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CH','China')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('KT','Christmas Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IP','Clipperton Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CK','Cocos (Keeling) Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CO','Colombia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CN','Comoros')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CF','Congo (Brazzaville)')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CG','Congo (Kinshasa)')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CW','Cook Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CR','Coral Sea Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CS','Costa Rica')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IV','Cote D''Ivoire (Ivory Coast)')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('HR','Croatia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CU','Cuba')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('UC','Curacao')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CY','Cyprus')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('EZ','Czech Republic')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('DA','Denmark')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('DX','Dhekelia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('DJ','Djibouti')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('DO','Dominica')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('DR','Dominican Republic')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TT','East Timor')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('EC','Ecuador')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('EG','Egypt')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('ES','El Salvador')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('EK','Equatorial Guinea')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('ER','Eritrea')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('EN','Estonia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('ET','Ethiopia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FK','Falkland Islands (Islas Malvinas)')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FO','Faroe Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FM','Federated States of Micronesia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FJ','Fiji')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FI','Finland')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FR','France')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FP','French Polynesia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('FS','French Southern and Antarctic Lands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GB','Gabon')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GA','The Gambia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GG','Georgia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('GM','Germany')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LG','Latvia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LE','Lebanon')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LT','Lesotho')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LI','Liberia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LY','Libya')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LS','Liechtenstein')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LH','Lithuania')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('LU','Luxembourg')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MC','Macau')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MK','Macedonia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MA','Madagascar')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MI','Malawi')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MY','Malaysia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MV','Maldives')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('ML','Mali')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MT','Malta')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('IM','Man, Isle of')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('RM','Marshall Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MR','Mauritania')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MP','Mauritius')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MX','Mexico')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MQ','Midway Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MD','Moldova')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MN','Monaco')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MG','Mongolia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MJ','Montenegro')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MH','Montserrat')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MO','Morocco')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('MZ','Mozambique')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('WA','Namibia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NR','Nauru')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('BQ','Navassa Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NP','Nepal')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NL','Netherlands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NC','New Caledonia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NZ','New Zealand')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NU','Nicaragua')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NG','Niger')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NI','Nigeria')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NE','Niue')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NF','Norfolk Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CQ','Northern Mariana Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('ST','St. Lucia Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SB','St. Pierre and Miquelon')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('VC','St. Vincent and the Grenadines')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SU','Sudan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NS','Suriname')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SV','Svalbard')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('WZ','Swaziland')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SW','Sweden')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SZ','Switzerland')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SY','Syria')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TW','Taiwan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TI','Tajikistan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TZ','Tanzania')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TH','Thailand')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TO','Togo')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TL','Tokelau')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TN','Tonga')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TD','Trinidad and Tobago')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TS','Tunisia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TU','Turkey')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TX','Turkmenistan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TK','Turks and Caicos Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('TV','Tuvalu')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('UG','Uganda')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('UP','Ukraine')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('AE','United Arab Emirates')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('UK','United Kingdom (England, Northern Ireland, Scotland, and Wales)')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('UY','Uruguay')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('UZ','Uzbekistan')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('NH','Vanuatu')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('VE','Venezuela')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('VM','Vietnam')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('VQ','Virgin Islands')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('WQ','Wake Island')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('WF','Wallis and Futuna')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('WI','Western Sahara')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('YM','Yemen (Aden)')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('ZA','Zambia')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('ZI','Zimbabwe')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('CE','Sri Lanka')
INSERT INTO [dbo].[country] ([country_code], [country_name]) VALUES ('SC','St. Kitts and Nevis')
GO

/*12Mar2014 N.SARAVANAN Added static data for filing_status table.*/
/*17Mar2014 vivekkumar Added the Civil Union and Same sex Marriage*/
INSERT INTO [dbo].[filing_status] ([filing_status]) VALUES (N'Single')
INSERT INTO [dbo].[filing_status] ([filing_status]) VALUES (N'Married Filing jointly')
INSERT INTO [dbo].[filing_status] ([filing_status]) VALUES (N'Married Filing Separately(Divorced or legally separated)')
INSERT INTO [dbo].[filing_status] ([filing_status]) VALUES (N'Registered domestic partnership or Civil Union')
INSERT INTO [dbo].[filing_status] ([filing_status]) VALUES (N'Same sex Marriage')
INSERT INTO [dbo].[filing_status] ([filing_status]) VALUES (N'Widower')
INSERT INTO [dbo].[filing_status] ([filing_status]) VALUES (N'Head of Household')
GO

/*12Mar2014 N.SARAVANAN Added static data for person_type table.*/
INSERT INTO [dbo].[person_type] ([person_type]) VALUES (N'PrimaryTaxPayer')
INSERT INTO [dbo].[person_type] ([person_type]) VALUES (N'Spouse')
INSERT INTO [dbo].[person_type] ([person_type]) VALUES (N'Dependent')
GO

/*19Mar2014 Ashok Kumar Added static data for [error_message]  table*/
/*Modification History*/
/*20Mar2014 Ashok Kumar Added static data for [error_message]  table*/
/*04Apr2014 Sathish Add new error message for spouse phone number*/
/*2ndApr014 Ashok Kumar Added static data for [error_message]  table- Interest Income and Unemployment Section*/


--SignUp error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_RF1', N'Email Address', N'Email Address', N'SignUp', N'PreLogin', N'Error', N'RF', N'Missing Email Address', N'Email Address should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_V1', N'Email Address', N'Email Address', N'SignUp', N'PreLogin', N'Error', N'V', N'Invalid Email Address', N'You have entered invalid Email Address. Please enter a valid Email Address.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_RF2', N'Username', N'Username', N'SignUp', N'PreLogin', N'Error', N'RF', N'Missing Username', N'Username should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_RF3', N'Password', N'Username', N'SignUp', N'PreLogin', N'Error', N'V', N'Missing Password', N'Password should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_V2', N'Password', N'Password', N'SignUp', N'PreLogin', N'Error', N'V', N'Invalid Password', N'Your Password must have 8 to 15 characters inclusive of one number and one special character.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_RF4', N'Confirm Password', N'Confirm Password', N'SignUp', N'PreLogin', N'Error', N'RF', N'Missing Confirm Password', N'Confirm Password should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_V3', N'Confirm Password', N'Confirm Password', N'SignUp', N'PreLogin', N'Error', N'V', N'Confirm Password and Password do not match', N'Your Password and Confirm Password must be same', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_RF5', N'Security Question', N'Security Question', N'SignUp', N'PreLogin', N'Error', N'RF', N'Security Question Missing', N'Security Question should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_RF6', N'Answer', N'Answer', N'SignUp', N'PreLogin', N'Error', N'RF', N'Answer for the question is Missing', N'Answer should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_V4', N'Username', N'Username', N'SignUp', N'PreLogin', N'Error', N'V', N'Invalid Username', N'Your Username must have atleast 6 Characters which includes alphabets, numbers and underscore.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_RF7', N'Terms and Services', N'Terms of Services', N'SignUp', N'PreLogin', N'Error', N'RF', N'Terms of Services not accepted', N'You have to agree with the Terms of Services.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_V5', N'Username', N'Username', N'SignUp', N'PreLogin', N'Error', N'V', N'Existing Username', N'The Username already exists. Please provide different name.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_V6', N'Email Address', N'Email Address', N'SignUp', N'PreLogin', N'Error', N'V', N'Existing Email ID', N'The Email Address already exists. You can Sign In or Recover your account.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignUp_V7', N'Password', N'Password', N'SignUp', N'PreLogin', N'Error', N'V', N'Your Username and Password should not be same.', N'Your Username and Password should not be same.', N'', N'', 0)

--SignIn error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignIn_RF1', N'Username', N'Username', N'SignIn', N'PreLogin', N'Error', N'RF', N'Missing Username', N'Username should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignIn_V1', N'Username', N'Username', N'SignIn', N'PreLogin', N'Error', N'V', N'Incorrect Username', N'The Username or Password entered is Incorrect. Please confirm your entries.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignIn_RF2', N'Password', N'Password', N'SignIn', N'PreLogin', N'Error', N'RF', N'Missing Password', N'Password should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignIn_V2', N'Password', N'Password', N'SignIn', N'PreLogin', N'Error', N'V', N'Incorrect Password', N'The Username or Password entered is Incorrect. Please confirm your entries.', N'', N'', 0)

--SignInIssues error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF1', N'Username', N'Username', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing Username', N'Username should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_V1', N'Incorrect Login Info', N'Incorrect Login Info', N'SignInIssues', N'PreLogin', N'Error', N'V', N'Incorrect Information', N'You entered Incorrect Information. Please confirm all your entries.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF2', N'Secret Answer', N'Secret Answer', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing Secret Answer', N'Answer should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF3', N'Secret Code', N'Secret Code', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing Secret Code', N'Secret Code should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_V2', N'Secret Code', N'Secret Code', N'SignInIssues', N'PreLogin', N'Error', N'V', N'Invalid Secret Code', N'You have entered the Invalid Secret Code. Please enter the valid Secret Code sent to your Email address.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF4', N'New Password', N'New Password', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing New Password', N'New Password should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_V3', N'New Password', N'New Password', N'SignInIssues', N'PreLogin', N'Error', N'V', N'Invalid Password', N'Your Password must have 8 to 15 characters inclusive of one number and one special character.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF5', N'Confirm Password', N'Confirm Password', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Confirm Password', N'Confirm Password should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_V4', N'Confirm Password', N'Confirm Password', N'SignInIssues', N'PreLogin', N'Error', N'V', N'Invalid Confirm Password', N'Your Password and Confirm Password  must be same ', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF6', N'Email ID', N'Email address', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing Email address', N'Email Address should not be Empty', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_V5', N'Email ID', N'Email address', N'SignInIssues', N'PreLogin', N'Error', N'V', N'Invalid Email ID', N'You have entered invalid Email Address. Please enter a valid Email Address.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF7', N'First Name', N'FirstName', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing First Name', N'First name should not be Empty.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_V6', N'First Name', N'FirstName', N'SignInIssues', N'PreLogin', N'Error', N'V', N'Special Characters', N'First name - Use only alphabets. (No special characters, numbers and Punctuations).', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF8', N'Last Name', N'Last name', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing Last Name', N'Last name should not be Empty.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_V7', N'Last Name', N'Last name', N'SignInIssues', N'PreLogin', N'Error', N'V', N'Special Characters', N'Last name - Use only alphabets. (No special characters, numbers and Punctuations).', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF9', N'Date of Birth', N'Date of Birth', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing Date of Birth', N'Date of Birth should not be Empty.', N'', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'SignInIssues_RF10', N'New Email Address', N'New Email address', N'SignInIssues', N'PreLogin', N'Error', N'RF', N'Missing New Email address', N'Email Address should not be Empty', N'', N'', 0)

--Filing Status error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'FilingStatus_RF1', N'TP Filing Status', N'Filing Status of Taxpayer', N'PersonalInfo', N'FilingStatus', N'Error', N'RF', N'Missing selection of Filing Status', N'Confirm the Filing Status of Taxpayer', N'/PersonalInfo/FilingStatus.html', N'Make a selection of Filing Status of Taxpayer', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'FilingStatus_ER1', N'TP Filing Status', N'Filing Status of Taxpayer', N'PersonalInfo', N'FilingStatus', N'Error', N'ER', N'Filing Status is not Single or MFJ', N'Your filing Status must be Single or Married filing Jointly', N'/PersonalInfo/FilingStatus.html', N'Your Filing Status must be Single or Married Filing Jointly', 0)


--Primary Filer error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_RF1', N'collapseOne-txtfirstname', N'Taxpayer First Name', N'PersonalInfo', N'PrimaryFiler', N'Error', N'RF', N'Missing Taxpayer First Name', N'You have Missed  out the First Name of Taxpayer', N'/PersonalInfo/PrimaryFilerInfo.html', N'You have Missed out the First Name of Taxpayer', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_V1', N'collapseOne-txtfirstname', N'Taxpayer First Name', N'PersonalInfo', N'PrimaryFiler', N'Warning', N'V', N'Special characters on Taxpayer First Name', N'First Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/PrimaryFilerInfo.html', N'First Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_RF2', N'collapseOne-txtlastname', N'Taxpayer Last Name', N'PersonalInfo', N'PrimaryFiler', N'Error', N'RF', N'Missing Taxpayer Last Name', N'You have Missed  out the Last Name of Taxpayer', N'/PersonalInfo/PrimaryFilerInfo.html', N'You have Missed  out the Last Name of Taxpayer', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_V2', N'collapseOne-txtlastname', N'Taxpayer Last Name', N'PersonalInfo', N'PrimaryFiler', N'Warning', N'V', N'Special characters on Taxpayer Last Name', N'Last Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/PrimaryFilerInfo.html', N'Last Name: Use only Alphabets. (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_V3', N'collapseOne-txtmiddleinitial', N'Taxpayer Middle Name', N'PersonalInfo', N'PrimaryFiler', N'Warning', N'V', N'Special characters on Taxpayer Middle Name', N'Middle Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/PrimaryFilerInfo.html', N'Middle Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_V4', N'collapseOne-txtnickname', N'Taxpayer Nick Name', N'PersonalInfo', N'PrimaryFiler', N'Warning', N'V', N'Special characters on Taxpayer Nick Name', N'Nick Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/PrimaryFilerInfo.html', N'Nick Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_V5', N'collapseOne-txtoccupation', N'Taxpayer Occupation', N'PersonalInfo', N'PrimaryFiler', N'Warning', N'V', N'Special characters on Taxpayer Occupation', N'Occupation Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/PrimaryFilerInfo.html', N'Occupation Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_V6', N'collapseOne-txtoccupation', N'Taxpayer Occupation', N'PersonalInfo', N'PrimaryFiler', N'Information', N'V', N'Missing Occupation Name', N'You have Missed out the Occupation of Taxpayer', N'/PersonalInfo/PrimaryFilerInfo.html', N'You have Missed out the Occupation of Taxpayer', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_RF3', N'collapseTwo-dtdateofbirth', N'Taxpayer Date of Birth', N'PersonalInfo', N'PrimaryFiler', N'Error', N'RF', N'Missing Taxpayer Date of Birth', N'You have Missed out the  Date of Birth  of Taxpayer', N'/PersonalInfo/PrimaryFilerInfo.html', N'You have Missed out the Date of Birth  of Taxpayer', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_ER1', N'collapseTwo-dtdateofbirth', N'Taxpayer Date of Birth', N'PersonalInfo', N'PrimaryFiler', N'Error', N'ER', N'Taxpayer age must be less than 65', N'You & Your Spouse (if MFJ) must be under the age of 65 as of January 1, 2014.', N'/PersonalInfo/PrimaryFilerInfo.html', N'Taxpayer age must be under the Age of 65 as of January 1, 2014.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_RF4', N'collapseTwo-txtssn', N'Taxpayer Social Security Number', N'PersonalInfo', N'PrimaryFiler', N'Error', N'RF', N'Missing Taxpayer SSN', N'You have Missed out the  Social Security Number of Taxpayer', N'/PersonalInfo/PrimaryFilerInfo.html', N'You have Missed out the  Social Security Number of Taxpayer', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_V7', N'collapseTwo-txtssn', N'Taxpayer Social Security Number', N'PersonalInfo', N'PrimaryFiler', N'Error', N'V', N'Invalid Taxpayer SSN', N'Taxpayer Social Security Number is invalid. Please enter a valid SSN.', N'/PersonalInfo/PrimaryFilerInfo.html', N'Taxpayer Social Security Number is invalid. Please enter a valid Social Security Number', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_RF5', N'collapseFour-dtdateofdeath', N'Taxpayer Date of Death', N'PersonalInfo', N'PrimaryFiler', N'Error', N'RF', N'Missing Taxpayer Date of Death', N'You have Missed out the Death Date of Taxpayer.', N'/PersonalInfo/PrimaryFilerInfo.html', N'You have Missed out the Date of Death of Taxpayer.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_V8', N'collapseFour-dtdateofdeath', N'Taxpayer Date of Death', N'PersonalInfo', N'PrimaryFiler', N'Error', N'V', N'Taxpayer Date of Death is not in Tax year', N'The Death Year of Taxpayer must be the current tax year 2014.', N'/PersonalInfo/PrimaryFilerInfo.html', N'The Year of Death of Taxpayer must be the current tax year 2014.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_BR1', N'collapseFour-dtdateofdeath', N'Taxpayer Date of Death', N'PersonalInfo', N'PrimaryFiler', N'Warning', N'BR', N'Not supporting the attachment Form 1310', N'You need to attach Form 1310, to claim refund for the Deceased Taxpayer. We regret to inform You that we are not supporting the attachment Form 1310. ', N'/PersonalInfo/PrimaryFilerInfo.html', N'You need to attach Form 1310, to claim refund for the Deceased Taxpayer. We regret to inform You that we are not supporting the attachment Form 1310. ', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_ER2', N'collapseFour-chklegallybliend', N'Taxpayer is Blind', N'PersonalInfo', N'PrimaryFiler', N'Error', N'ER', N'Taxpayer should not be Blind as of Jan 1st 2014.', N'You & Your Spouse (if MFJ) should not be legally Blind as of January 1, 2014.', N'/PersonalInfo/PrimaryFilerInfo.html', N'Taxpayer should not be legally Blind as of January 1, 2014.', 0)
-- Sathish 08May2014 added error message for Date Birth
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'PrimaryFiler_V9','collapseFour-dtdateofdeath','Taxpayer Date of Birth','PersonalInfo','PrimaryFiler','Information','V','Missing Taxpayer Date of Birth','You have Missed out the Occupation of Taxpayer','/PersonalInfo/PrimaryFilerInfo.html',NULL)
-- Bala 09May2014 added error message for Date of Death
-- Prasana 02June2014 Modified short error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'PrimaryFiler_ER3', N'collapseFour-dtdateofdeath', N'Taxpayer Date of Death', N'PersonalInfo', N'PrimaryFiler', N'Error', N'ER', N'You need to attach Form 1310, to claim refund for the Deceased Taxpayer', N'You need to attach Form 1310, to claim refund for the Deceased Taxpayer. We regret to inform You that we are not supporting the attachment Form 1310.', N'/PersonalInfo/PrimaryFilerInfo.html', N'You need to attach Form 1310, to claim refund for the Deceased Taxpayer.', 0)

--Spouse error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_RF1', N'collapseOne-txtfirstname', N'Spouse First Name', N'PersonalInfo', N'Spouse', N'Error', N'RF', N'Missing Spouse First Name', N'You have Missed out  the Spouse First Name', N'/PersonalInfo/SpouseInfo.html', N'You have Missed out the First Name of spouse', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_V1', N'collapseOne-txtfirstname', N'Spouse First Name', N'PersonalInfo', N'Spouse', N'Warning', N'V', N'Special characters on Spouse First Name', N'Spouse First Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/SpouseInfo.html', N'Spouse First Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_RF2', N'collapseOne-txtlastname', N'Spouse Last Name', N'PersonalInfo', N'Spouse', N'Error', N'RF', N'Missing Spouse Last Name', N'You have Missed out  the Spouse Last Name', N'/PersonalInfo/SpouseInfo.html', N'You have Missed out the Last Name of Spouse', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_V2', N'collapseOne-txtlastname', N'Spouse Last Name', N'PersonalInfo', N'Spouse', N'Warning', N'V', N'Special characters on Spouse Last Name', N'Spouse Last Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/SpouseInfo.html', N'Spouse Last Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_V3', N'collapseOne-txtmiddleinitial', N'Spouse Middle Name', N'PersonalInfo', N'Spouse', N'Warning', N'V', N'Special characters on SpouseMiddle Name', N'Spouse Middle Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/SpouseInfo.html', N'Spouse Middle Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_RF3', N'collapseOne-txtSSN', N'Spouse Social Security Number', N'PersonalInfo', N'Spouse', N'Error', N'RF', N'Missing Spouse SSN', N'You have Missed out the  Spouse Social Security Number', N'/PersonalInfo/SpouseInfo.html', N'You have Missed out the Social Security Number of Spouse', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_V4', N'collapseOne-txtSSN', N'Spouse Social Security Number', N'PersonalInfo', N'Spouse', N'Error', N'V', N'Invalid Spouse SSN', N'Spouse Social Security Number is invalid. Please enter a valid SSN.', N'/PersonalInfo/SpouseInfo.html', N'Your Spouse Social Security Number is invalid. Please enter a valid SSN.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_RF4', N'collapseOne-dtdateofbirth', N'Spouse Date of birth', N'PersonalInfo', N'Spouse', N'Error', N'RF', N'Missing Spouse Date of birth', N'You have Missed out the  Date of Birth  of Spouse', N'/PersonalInfo/SpouseInfo.html', N'You have Missed out the Date of Birth of Spouse', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_V5', N'collapseOne-txtoccupation', N'Spouse Occupation', N'PersonalInfo', N'Spouse', N'Warning', N'V', N'Special characters on Spouse Occupation', N'Spouse Occupation:  Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/SpouseInfo.html', N'Spouse Occupation:  Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_V6', N'collapseOne-txtoccupation', N'Spouse Occupation', N'PersonalInfo', N'Spouse', N'Information', N'V', N'Missing  Spouse Occupation Name', N'You have Missed out the Spouse  Occupation ', N'/PersonalInfo/SpouseInfo.html', N'You have Missed out the Occupation of Spouse', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_RF5', N'collapseOne-chkspouselived', N'Spouse State of residence', N'PersonalInfo', N'Spouse', N'Error', N'RF', N'Spouse State of Residence Missing', N'You have Missed  out the Your Spouse State of resident', N'/PersonalInfo/SpouseInfo.html', N'You have Missed out the State of Resident for spouse.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_RF6', N'collapseTwo-dtDOD', N'Spouse Date of Death', N'PersonalInfo', N'Spouse', N'Error', N'RF', N'Missing Spouse Date of Death', N'You have Missed out the Spouse Date of Death', N'/PersonalInfo/SpouseInfo.html', N'You have Missed out the Date of Death of Spouse', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_V7', N'collapseTwo-dtDOD', N'Spouse Date of Death', N'PersonalInfo', N'Spouse', N'Error', N'V', N'Spouse Date of Death is not in Tax year', N'The Death Year of Spouse must be the current tax year 2014', N'/PersonalInfo/SpouseInfo.html', N'The Death Year of Spouse must be the current tax year 2014', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_BR1', N'collapseTwo-dtDOD', N'Spouse Date of Death', N'PersonalInfo', N'Spouse', N'Error', N'BR', N'Not supporting the attachment Form 1310', N'You need to attach Form 1310, to claim refund for the Deceased Spouse. We regret to inform You that we are not supporting the attachment Form 1310. ', N'/PersonalInfo/SpouseInfo.html', N'You need to attach Form 1310, to claim refund for the Deceased Spouse. We regret to inform You that we are not supporting the attachment Form 1310. ', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_ER1', N'collapseOne-dtdateofbirth', N'Spouse Date of Birth', N'PersonalInfo', N'Spouse', N'Error', N'ER', N'Spouse age must be less than 65', N'You & Your Spouse (if MFJ) must be under the age of 65 as of January 1, 2014.', N'/PersonalInfo/SpouseInfo.html', N'Spouse age must be under the Age of 65 as of January 1, 2014.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_ER2', N'collapseTwo-chkSpouseBlind', N'Spouse is Blind', N'PersonalInfo', N'Spouse', N'Error', N'ER', N'Spouse should not be Blind as of Jan 1st 2014.', N'You & Your Spouse (if MFJ) should not be legally Blind as of January 1, 2014.', N'/PersonalInfo/SpouseInfo.html', N'Spouse  should not be legally Blind as of January 1, 2014.', 0)
-- Sathish 08May2014 added error message for Date Birth
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'Spouse_V8','collapseOne-dtdateofbirth','Spouse Date of Birth','PersonalInfo','Spouse','Error','RF','Your  Spouse year of birth should not be greater than tax year','You have Missed out the Date of Birth of Spouse',N'/PersonalInfo/SpouseInfo.html',NULL)
-- Bala 09May2014 added error message for Date of Death
-- Prasana 02June2014 Modified short error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Spouse_ER3', N'collapseTwo-dtDOD', N'Spouse Date of Death', N'PersonalInfo', N'Spouse', N'Error', N'ER', N'You need to attach Form 1310, to claim refund for the Deceased Spouse', N'You need to attach Form 1310, to claim refund for the Deceased Spouse. We regret to inform You that we are not supporting the attachment Form 1310.', N'/PersonalInfo/SpouseInfo.html', N'You need to attach Form 1310, to claim refund for the Deceased Spouse.', 0)


--Address error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF1', N'collapseOne-txtStreetAddress', N'Street Address', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Street Address', N' You have Missed out the Street Address', N'/PersonalInfo/Address.html', N' You have Missed out the Street Address', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V1', N'collapseOne-txtStreetAddress', N'Street Address', N'PersonalInfo', N'Address', N'Warning', N'V', N'Special characters on Street Address', N'Street Address: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/Address.html', N'Street Address: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF2', N'collapseOne-txtCity', N'City Name', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing City Name', N'City Name should not be empty', N'/PersonalInfo/Address.html', N'City Name should not be empty', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V2', N'collapseOne-txtCity', N'City Name', N'PersonalInfo', N'Address', N'Warning', N'V', N'Special characters on City name.', N'City Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/Address.html', N'City Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF3', N'collapseOne-ddlState', N'State Code', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing State Code', N'Select the appropriate State Code. (For instance, CA->California).', N'/PersonalInfo/Address.html', N'Select the appropriate State Code. (For instance, CA->California).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF4', N'collapseOne-txtZipCode', N'Zip Code', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Zip Code', N'Zip Code should not be empty', N'/PersonalInfo/Address.html', N'Zip Code should not be empty', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V3', N'collapseOne-txtZipCode', N'Zip Code', N'PersonalInfo', N'Address', N'Error', N'V', N'Invalid Zip Code', N'You have entered an invalid Zip Code. Please check and enter.', N'/PersonalInfo/Address.html', N'You have entered an invalid Zip Code. Please check and enter.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V4', N'collapseOne-txtPhoneNumber', N'Phone Number', N'PersonalInfo', N'Address', N'Information', N'V', N'Invalid Phone Number', N'You have entered an incorrect Phone Number. Please enter a valid 10 digit Number', N'/PersonalInfo/Address.html', N'You have entered an incorrect Phone Number. Please enter a valid 10 digit Number', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V10', N'collapseOne-txtForeignPhoneNumber', N'Foreign Phone Number', N'PersonalInfo', N'Address', N'Information', N'V', N'Invalid Foreign Phone Number', N'You have entered an incorrect Foreign Phone Number. Please enter a valid 10 digit Number', N'/PersonalInfo/Address.html', N'You have entered an incorrect Foreign Phone Number. Please enter a valid 10 digit Number', 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF5', N'collapseOne-txtForeignStreetAddress', N'Foreign Street Address', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Foreign  Street Address', N' You have Missed out the Foreign Street Address', N'/PersonalInfo/Address.html', N' You have Missed out the Foreign Street Address', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V5', N'collapseOne-txtForeignStreetAddress', N'Foreign Street Address', N'PersonalInfo', N'Address', N'Warning', N'V', N'Special characters on Foreign Street Address', N'Foreign Street Address:  Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/Address.html', N'Foreign Street Address:  Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF6', N'collapseOne-txtForeignCity', N'City Name', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Foreign City Name', N'You have Missed out the Foreign City Name', N'/PersonalInfo/Address.html', N'You have Missed out the Foreign City Name', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V6', N'collapseOne-txtForeignCity', N'City Name', N'PersonalInfo', N'Address', N'Warning', N'V', N'Special characters on Foreign city Name', N'Foreign City Name:  Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/Address.html', N'Foreign City Name:  Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF7', N'collapseOne-txtStateorprovince', N'State Name', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Foreign State Name', N'You have Missed out the Foreign State Name', N'/PersonalInfo/Address.html', N'You have Missed out the Foreign State Name', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V7', N'collapseOne-txtStateorprovince', N'State Name', N'PersonalInfo', N'Address', N'Warning', N'V', N'Special characters on Foreign State name.', N'Foreign State Name: Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/Address.html', N'Foreign State Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF8', N'collapseOne-txtPostalCode', N'Postal Code', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Foreign Postal Code', N'You have Missed out the Foreign Pin Code', N'/PersonalInfo/Address.html', N'You have Missed out the Foreign Pin Code', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF9', N'collapseOne-ddlCountryName', N'Foreign Country Name', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Foreign Country Name', N'You have Missed out the Foreign Country Name', N'/PersonalInfo/Address.html', N'You have Missed out the Foreign Country Name', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V8', N'collapseOne-ddlCountryName', N'Foreign Country Name', N'PersonalInfo', N'Address', N'Warning', N'V', N'Special characters on Foreign Country Name', N'Foreign Country Name:  Use only Alphabets. IRS does not accept special characters, Numbers, and punctuations to file Your tax return electronically.', N'/PersonalInfo/Address.html', N'Foreign Country Name:  Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF10', N'collapseTwo-ddlStateOfResidence', N'State of residence Name', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Resident State Name', N'You have Missed out the Resident State Name', N'/PersonalInfo/Address.html', N'You have Missed out the State Name of Residence', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF11', N'collapseTwo-ddlMoreThanOneState', N'State of residence Name', N'PersonalInfo', N'Address', N'Error', N'RF', N'State of Residence for more than one State', N'State of Residence for more than one State is required entry', N'/PersonalInfo/Address.html', N'State of Residence for more than one State is required', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF12', N'collapseTwo-dtFromDate', N'Date of move to new State from Date', N'PersonalInfo', N'Address', N'Error', N'RF', N'New State of Residence  ''From Date'' is required entry', N'New State of Residence  ''From Date'' is required.', N'/PersonalInfo/Address.html', N'Date of move "from Date" of New State of Residence is required', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF13', N'collapseTwo-dtToDate', N'Date of move to new State To Date', N'PersonalInfo', N'Address', N'Error', N'RF', N'New State of Residence ''To Date'' is required entry', N'New State of Residence ''To Date'' is required.', N'/PersonalInfo/Address.html', N'Date of move "To Date" of New State of Residence is required', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF14', N'collapseTwo-ddlEarnedIncomeStateNotLived', N'State Name for earned Income in more than 1 State', N'PersonalInfo', N'Address', N'Error', N'RF', N'State name for earned Income in more than one State is required entry.', N'"State name not selected for Earned Income from Nonresident state."', N'/PersonalInfo/Address.html', N'State name for Earned Income in more than one State is required', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V9', N'collapseTwo-collapseTwo-divMoreThanOneState', N'Lived in More than 1 State', N'PersonalInfo', N'Address', N'Error', N'RF', N'Taxpayer lived in more than one state is required entry.', N'', N'/PersonalInfo/Address.html', N'You have lived in More than one State for the Tax year 2014. And this program doesn''t support the State part year tax return. ', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF15', N'collapseOne-txtPhoneNumber', N'Phone Number', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Phone Number', N'You have missed out the Phone number', N'/PersonalInfo/Address.html', N'', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_RF16', N'collapseOne-txtForeignPhoneNumber', N'Foreign Phone Number', N'PersonalInfo', N'Address', N'Error', N'RF', N'Missing Foreign Phone Number', N'You have missed out the Foreign Phone Number', N'/PersonalInfo/Address.html', N'', 0)

--Added by Swapnesh on 28 May 2014
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V12', N'collapseTwo-ddlStateOfResidence', N'Resident State name', N'PersonalInfo', N'Address', N'Error', N'V', N'Your Resident state name and Part year resident name should not be same.', N' Your Resident state name and Part year resident name should not be same.', N'/PersonalInfo/Address.html', N'Your Resident state name and Part year resident name should not be same.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description],[tab], [topic], [error_type], [message_type], [short_error_text],  [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V13', N'collapseTwo-ddlMoreThanOneState', N'2014 resident name', N'PersonalInfo', N'Address', N'Error', N'V', N'Your Resident State name and Non resident state name should not be same.', N'Your Resident State name and Non resident state name should not be same.', N'/PersonalInfo/Address.html', N'Your Resident State name and Non resident state name should not be same.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V14', N'collapseTwo-dtFromDate', N'From Date', N'PersonalInfo', N'Address', N'Error', N'V', N' New State of Residence  ''From Date'' should be within Tax year.', N' New State of Residence  ''From Date'' should be within Tax year', N'/PersonalInfo/Address.html', N' New State of Residence  "From Date" should be within Tax year', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V15', N'collapseTwo-dtToDate', N'To Date', N'PersonalInfo', N'Address', N'Error', N'V', N' New State of Residence ''To Date'' should be within Tax year.', N' New State of Residence ''To Date'' should be within Tax year', N'/PersonalInfo/Address.html', N' New State of Residence "To Date" should be within Tax year', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Address_V16', N'collapseTwo-dtToDate', N'To Date', N'PersonalInfo', N'Address', N'Error', N'V', N' You have entered an Invalid Date. Check your ''To date'' for New state of Residence.', N' You have entered an Invalid Date. Check your "To date" for New state of Residence.', N'/PersonalInfo/Address.html', N' You have entered an Invalid Date. Check your "To date" for New state of Residence.', 0)


--EzEligibility error message
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER1', N'Claim exemption for dependent', N'Claim exemption for dependent', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N'Claiming dependent', N'You should not claim any dependent on tax return.', N'', N'You should not claim any Dependent on your  tax return.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER2', N'Received Income apart from Wages, Unemployment & interest Income', N'Received Income apart from Wages, Unemployment & interest Income', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N'You & Your Spouse (if MFJ) not have any other Taxable Income.', N'You & Your Spouse (if MFJ) should not have any other taxable Income apart from Wages, UnemploymentCompensation and Interest Income', N'', N'You & Your Spouse (if MFJ) should not have any other taxable Income apart from Wages, Unemployment compensation and Interest Income', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER3', N'No AGI deductions', N'No Adjusted Gross Income deductions', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N'You should not Incur any AGI deductions', N'You should not incur any adjusted gross Income deductions (such as student loan interest, IRA contribution and Tuition fees deduction, Moving expenses, Early withdrawal penalty, Alimony paid, H S A Contribution and Health Insurance).', N'', N'You should not incur any Adjusted Gross Income Deductions (such as student loan interest, IRA contribution and Tuition fees deduction, Moving expenses, Early withdrawal penalty, Alimony paid, H S A Contribution and Health Insurance).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER4', N'No itemized deduction', N'Taxpayer cant claim any deduction for Itemized expenses', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N'You should not claim any credits', N'You should not claim any credits with the exception of EIC (such as Education credit, Retirement contribution credit, foreign tax credit, dependent care credit and child tax credit).', N'', N'You should not claim any Credits (such as Education credit, Retirement contribution credit, foreign tax credit, dependent care credit and child tax credit) with the exception of Earned Income Credit (EIC).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER5', N'No Credits', N'Taxpayer cant claim any credits except EIC', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N'You should not claim any Itemized deductions', N'You should not claim any Itemized deductions (such as Medical Expenses, Real eState taxes, Mortgage Interest, Charitable contribution and other miscellaneous deduction)', N'', N'You should not claim any Itemized deductions (such as Medical Expenses, Real eState taxes, Mortgage Interest, Charitable contribution and other miscellaneous deduction)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER6', N'NO household employment taxes', N'Taxpayer not to claim any Household employment tax', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N'You & Your Spouse (if MFJ) should not subject to any household employment Taxes', N'You & Your Spouse (if MFJ) should not subject to any household employment taxes on wages paid to household employees.', N'', N'You & Your Spouse (if MFJ) should not subject to any Household Employment taxes on Wages paid to Household Employees.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER7', N'NO AMT taxes', N'Taxpayer not to Incur any AMT taxes', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N'You should not subject to AMT Taxes', N'You are not subject to AMT taxes on Your personal tax return and not allowed to claim Your Prior year minimum tax credit.', N'', N'You should not subject to AMT taxes and not allowed to claim Your Prior year minimum tax credit .', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER8', N'No estimate payments', N'Taxpayer should not pay any estimates', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N' You should not have made estimated Tax payments for federal and State', N'You should not make any Federal, State and Local Estimates.', N'', N'You should not have made Estimated tax payments for Federal and State', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'EZEligibility_ER9', N'TP should not be under any Bankruptcy case', N'Taxpayer should not be under any Bankruptcy case', N'PersonalInfo', N'EZEligibility', N'Error', N'ER', N'You should not be claimed as Debtor for bankruptcy', N'You & Your Spouse (if MFJ) should not be claimed as debtor in a Chapter 11 bankruptcy case filed after October 16, 2005.', N'', N'You & Your Spouse (if MFJ) should not be claimed as debtor in a Chapter 11 bankruptcy case filed after October 16, 2005.', 0)


--Wages error message
-- 15May14 Sathish corrected message target for the missing value
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF1', N'Whose W2 is this', N'Whose W2 is this', N'Income', N'Wages',  N'Error', N'RF', N'Missing Taxpayer or Spouse Code.', N' You have missed out to select the Taxpayer or Spouse Code.', N'/Income/W2.html', N' You have missed out to select the Taxpayer or Spouse Code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF2', N'Type of Employment', N'Type of Employment', N'Income', N'Wages',  N'Error', N'RF', N'Missing Type of Employment', N'You have missed out  to select the Type of Employment.', N'/Income/W2.html', N'You have missed out  to select the Type of Employment.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF3', N'collapseOne-txtW2EmployerID', N'Employer Identification Number', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employer Identification Number', N'Form W2 from <Employer Name>: You have missed out to enter  the Employer Identification Number.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out to enter  the Employer Identification Number.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V1', N'collapseOne-txtW2EmployerID', N'Employer Identification Number', N'Income', N'Wages',  N'Error', N'V', N'Invalid Employer Identification Number', N'Form W2 from <Employer Name>: You have entered an Invalid Employer Identification number. Please enter a valid EIN.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have entered an Invalid Employer Identification number. Please enter a valid EIN.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF4', N'collapseOne-txtW2EmployerName', N'Employer Name', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employer Name', N' You have missed out the Employer Name.', N'/Income/W2.html', N' You have missed out the Employer Name.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V2', N'collapseOne-txtW2EmployerName', N'Employer Name', N'Income', N'Wages',  N'Error', N'V', N'Special characters on Employer Name', N'Employer Name - Use only Alphabets (No Special Characters, Numbers & Punctuations).', N'/Income/W2.html', N'Employer Name - Use only Alphabets (No Special Characters, Numbers & Punctuations).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF5', N'collapseOne-txtW2EmployerAddress', N'Employer Address', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employer Address', N'Form W2 from <Employer Name>: You have missed out the Employer Address.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out the Employer Address.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V3', N'collapseOne-txtW2EmployerAddress', N'Employer Address', N'Income', N'Wages',  N'Error', N'V', N'Special Characters on Employer address', N'Form W2 from <Employer Name> Address - Use only Alphabets (No Special Characters, Numbers & Punctuations).', N'/Income/W2.html', N'Form W2 from <Employer Name> Address - Use only Alphabets (No Special Characters, Numbers & Punctuations).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF6', N'collapseOne-txtW2EmployerCity', N'Employer City', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employer City Name', N'Form W2 from <Employer Name>: You have missed out the Employer City Name.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out the Employer City Name.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V4', N'collapseOne-txtW2EmployerCity', N'Employer City', N'Income', N'Wages',  N'Error', N'V', N'Special characters on Employer city Name', N'Form W2 from <Employer Name> City - Use only Alphabets (No Special Characters, Numbers & Punctuations).', N'/Income/W2.html', N'Form W2 from <Employer Name> City - Use only Alphabets (No Special Characters, Numbers & Punctuations).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF7', N'collapseOne-ddlW2State', N'Employer State', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employer State', N'Form W2 from <Employer Name>: You have missed out to Select the Employer State Code.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out to Select the Employer State Code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF8', N'collapseOne-txtW2EmployerZip', N'Employer Zip Code', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employer Zip Code', N'Form W2 from <Employer Name>: You have missed out the Employer Zip Code.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out the Employer Zip Code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF9', N'collapseTwo-txtW2EmployeeAddress', N'Employee address', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employee address', N'Form W2 from <Employer Name>: You have missed out the Employee address.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out the Employee address.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V5', N'collapseTwo-txtW2EmployeeAddress', N'Employee address', N'Income', N'Wages',  N'Error', N'V', N'Special characters on Employee Address', N'Employee Address - Use only Alphabets (No Special Characters, Numbers & Punctuations)', N'/Income/W2.html', N'Employee Address - Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF10', N'collapseTwo-txtW2EmployeeCity', N'Employee City', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employee City', N'Form W2 from <Employer Name>:You have missed out the Employee City.', N'/Income/W2.html', N'Form W2 from <Employer Name>:You have missed out the Employee City.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V6', N'collapseTwo-txtW2EmployeeCity', N'Employee City', N'Income', N'Wages',  N'Error', N'V', N'Special characters on Employee city', N'Employee City - Use only Alphabets (No Special Characters, Numbers & Punctuations)', N'/Income/W2.html', N'Employee City - Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF11', N'collapseTwo-ddlW2EmployeeState', N'Employee State Code', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employee State Code', N'Form W2 from <Employer Name>:You have missed out to Select the Employee State Code.', N'/Income/W2.html', N'Form W2 from <Employer Name>:You have missed out to Select the Employee State Code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF12', N'collapseTwo-txtW2EmployeeZip', N'Employee Zip Code', N'Income', N'Wages',  N'Error', N'RF', N'Missing Employee Zip Code', N'Form W2 from <Employer Name>:You have missed out the Employee Zip Code.', N'/Income/W2.html', N'Form W2 from <Employer Name>:You have missed out the Employee Zip Code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF13', N'collapseThree-txtW2FederalWages', N'Box 1 Wage Income', N'Income', N'Wages',  N'Error', N'RF', N'Missing Box1 Wage Income', N'Form W2 from <Employer Name>: Box1 Wage Income should not be Empty.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box1 Wage Income should not be Empty.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF14', N'collapseThree-txtW2FederalWithheld', N'Box 2 Federal Tax Withheld', N'Income', N'Wages',  N'Error', N'RF', N'Missing Box2 Federal Tax Withheld', N'Form W2 from <Employer Name>: Box 2 Federal Tax Withheld Should not be Empty. If none, enter Zero', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 2 Federal Tax Withheld Should not be Empty. If none, enter Zero', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR1', N'collapseThree-txtW2FederalWithheld', N'Box 2 Federal Tax Withheld', N'Income', N'Wages',  N'Error', N'BR', N'Box2 Federal Tax Withheld should not be greater than Box1 Wages.', N'Form W2 from <Employer Name>:  Box2 Federal Tax Withheld should not be greater than Box1 Federal Wages.', N'/Income/W2.html', N'Form W2 from <Employer Name>:  Box2 Federal Tax Withheld should not be greater than Box1 Federal Wages.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR2', N'collapseThree-txtW2SSWages', N'Box 3 Social Security Wages', N'Income', N'Wages',  N'Warning', N'BR', N'Box 3 Social security wages should not be more than $117,000', N'Form W2 from <Employer Name>: Box3 Social Security Wages should not be more than $117,000.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box3 Social Security Wages should not be more than $117,000.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR3', N'collapseThree-txtW2SSwithheld', N'Box 4 Social security Tax Withheld', N'Income', N'Wages',  N'Warning', N'BR', N'Box 4 Employee social security Tax should be 6.20% of Social security wages.', N'Form W2 from <Employer Name>: Box 4 Employee social security Tax should be 6.20% of Social security wages and not more than $7,254.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 4 Employee social security Tax should be 6.20% of Social security wages and not more than $7,254.', 0)
--Yogalakshmi - 30th June 2014 - defect fix for TAX1040-14089 where the focus was not to the correct textbox.
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR4', N'collapseThree-txtW2MedicalWithheld', N'Box 6 Medicare Tax Withheld', N'Income', N'Wages',  N'Warning', N'BR', N'Box 6 Medicare Tax Withheld should not be greater than 1.45% of Box 5 Medicare wages', N'Form W2 from <Employer Name>: Box 6 Medicare Tax Withheld should not be greater than 1.45% of Box 5 Medicare wages.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 6 Medicare Tax Withheld should not be greater than 1.45% of Box 5 Medicare wages.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER1', N'collapseThree-txtW2AllocatedTips', N'Box 8 Allocated Tips', N'Income', N'Wages',  N'Error', N'ER', N'Box 8 Allocated Tips should be reported on Form 1040', N'Form W2 from <Employer Name>: Box 8 Allocated Tips amount Should be added with Box1 total wages and report it on line7 of Form1040. (You cannot file Form 1040EZ or Form 1040)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 8 Allocated Tips amount Should be added with Box1 total wages and report it on line7 of Form1040. (You cannot file Form 1040EZ or Form 1040)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER2', N'collapseThree-txtW2DependentCare', N'Box 10 Dependent care benefits', N'Income', N'Wages',  N'Error', N'ER', N'Box 10 Dependent care benefits Should be reported on Form 1040', N' Form W2 from <Employer Name>: Box 10 Dependent Care Benefits should add with Your box 1 total wages (if there is no dependent care expenses) and report the total as wages on line 7 of Form1040. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 10 Dependent Care Benefits should add with Your box 1 total wages (if there is no dependent care expenses) and report the total as wages on line 7 of Form1040. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER3', N'collapseFour-ddlW212A', N'Box 12A Uncollected Social Security or RRTA Tax on Tips. ', N'Income', N'Wages',  N'Error', N'ER', N'Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60', N'Form W2 from <Employer Name>: Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER4', N'collapseFour-ddlW212A', N'Box 12B Uncollected Medicare Tax on Tips. ', N'Income', N'Wages',  N'Error', N'ER', N'Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER5', N'collapseFour-ddlW212A', N'Box 12K Excise Tax (equal to 20%) on excess "golden parachute" payments. ', N'Income', N'Wages',  N'Error', N'ER', N'Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported Form 1040 Line 60 other Taxes. ', N' Form W2 from <Employer Name>: Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER6', N'collapseFour-ddlW212A', N'Box 12M Uncollected Social Security or RRTA Tax on Taxable group term life insurance over $50,000 for former employees', N'Income', N'Wages',  N'Error', N'ER', N'Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040  Line 60 other Taxes ', N'Form W2 from <Employer Name>: Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER7', N'collapseFour-ddlW212A', N'Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees. ', N'Income', N'Wages',  N'Error', N'ER', N'Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. ', N'Form W2 from <Employer Name>: Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR5', N'collapseFour-ddlW212A', N'Box 12R  Employer contributions to an Archer Medical Savings Account. ', N'Income', N'Wages',  N'Warning', N'BR', N' Box 12R Employer contribution to an Archer Medical savings Account amount must be reported on Form 8853.', N' Form W2 from <Employer Name>: Box 12R Employer contribution to an Archer Medical savings Account amount must be reported  on Form 8853. And this program doesn''t support this form.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12R Employer contribution to an Archer Medical savings Account amount must be reported  on Form 8853. And this program doesn''t support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR6', N'collapseFour-ddlW212A', N'Box 12T Employer paid adoption benefits. ', N'Income', N'Wages',  N'Warning', N'BR', N'Box 12T Employer paid adoption benefits amount must be reported on Form 8839.', N'Form W2 from <Employer Name>: Box 12T Employer paid adoption benefits amount must be reported on Form 8839. This program doesn''t support this form.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12T Employer paid adoption benefits amount must be reported on Form 8839. This program doesn''t support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR7', N'collapseFour-ddlW212A', N'Box12W Employer and employee contributions to a Health Savings Account. ', N'Income', N'Wages',  N'Warning', N'BR', N' Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889', N' Form W2 from <Employer Name>: Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889.This program don’t support this form.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889.This program don’t support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER8', N'collapseFour-ddlW212A', N'Box12Z Income received under 409A non-qualified deferred compensation plan. ', N'Income', N'Wages',  N'Error', N'ER', N'Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040  Line 60 other Taxes ', N'Form W2 from <Employer Name>: Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF15', N'collapseFive-ddlW2Box15State0', N'Box 15 State Code', N'Income', N'Wages',  N'Error', N'RF', N'Box15 State Code Missing', N'Form W2 from <Employer Name>: Box 15 State Code should not be Empty.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 15 State Code should not be Empty.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF16', N'collapseFive-txtW2StateID0', N'Box 15A State Identification Number', N'Income', N'Wages',  N'Error', N'RF', N'Box 15A State Identification Number Missing', N'Form W2 from <Employer Name>: Box 15A State Identification Number should not be Empty.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 15A State Identification Number should not be Empty.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF17', N'collapseFive-txtW2StateWages0', N'Box 16 State Wages', N'Income', N'Wages',  N'Error', N'RF', N'Box 16 State Wages Missing. If None, enter Zero', N'Form W2 from <Employer Name>: Box 16 State Wages Should not be Empty. If none, enter Zero', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 16 State Wages Should not be Empty. If none, enter Zero', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR8', N'collapseFive-txtW2StateWages0', N'Box 16 State Wages', N'Income', N'Wages',  N'Error', N'BR', N'Box16 State Wages should not be more than Box 1 Federal Wages.', N'Form W2 from <Employer Name>: Box16 State Wages should not be more than Box 1 Federal Wages.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box16 State Wages should not be more than Box 1 Federal Wages.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF18', N'collapseFive-txtW2StateWithheld0', N'Box 17 State Tax Withheld', N'Income', N'Wages',  N'Error', N'RF', N'Box 17 State Tax Withheld Missing. If none, enter Zero', N'Form W2 from <Employer Name>: Box 17 State Tax Withheld should not be Empty. If none, Enter Zero', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 17 State Tax Withheld should not be Empty. If none, Enter Zero', 0)
--Yogalakshmi - 19th June 2014 - changed the text from Box 17 should be greater than box 16 to Box 17 should not be greater than box 16 as discussed with BA.
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR9', N'collapseFive-txtW2StateWithheld0', N'Box 17 State Tax Withheld', N'Income', N'Wages',  N'Error', N'BR', N'Box 17 State Tax Withheld should not be greater than Box 16 State wages or Box 1 Federal wages', N' Form W2 from <Employer Name>:Box 17 State Tax Withheld should not be greater than Box 16 State wages or Box 1 Federal wages', N'/Income/W2.html', N' Form W2 from <Employer Name>:Box 17 State Tax Withheld should not be greater than Box 16 State wages or Box 1 Federal wages', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF19', N'collapseFive-txtW2LocalWages0', N'Box 18 Local Wages', N'Income', N'Wages',  N'Error', N'RF', N'Box 18 Local Wages should not be Empty', N'Form W2 from <Employer Name>: Box 18 Local Wages should not be Empty. If none, enter Zero', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 18 Local Wages should not be Empty. If none, enter Zero', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF20', N'collapseFive-txtW2LocalWithHeld0', N'Box 19 Local Tax Withheld', N'Income', N'Wages',  N'Error', N'RF', N'Box 19 Local Tax Withheld Missing', N'Form W2 from <Employer Name>: Box 19 Local Tax Withheld should not be Empty. If none, enter Zero', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 19 Local Tax Withheld should not be Empty. If none, enter Zero', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF21', N'collapseFive-txtW2LocalityName0', N'Box 20 Locality Name', N'Income', N'Wages',  N'Error', N'RF', N'Box 20 Locality Name is Missing', N'Form W2 from <Employer Name>: Box 20 Locality Name should not be Empty.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 20 Locality Name should not be Empty.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF22', N'collapseFour-txt12AAmount', N'Box 12A See Instruction', N'Income', N'Wages',  N'Error', N'RF', N'Box 12A See Instruction Code selected and amount is Missing', N' Form W2 from <Employer Name>: Box 12A See instruction Code 12---(A to Z) Should not be Empty.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12A See instruction Code 12---(A to Z) Should not be Empty.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF23', N'collapseFour-txt12BAmount', N'Box 12BSee Instruction', N'Income', N'Wages',  N'Error', N'RF', N'Box 12B See Instruction Code selected and amount is Missing', N' Form W2 from <Employer Name>: Box 12B See instruction Code 12---(A to Z) Should not be Empty.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12B See instruction Code 12---(A to Z) Should not be Empty.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF24', N'collapseFour-txt12CAmount', N'Box 12CSee Instruction', N'Income', N'Wages',  N'Error', N'RF', N'Box 12C See Instruction Code selected and amount is Missing', N' Form W2 from <Employer Name>: Box 12C See instruction Code 12---(A to Z) Should not be Empty.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12C See instruction Code 12---(A to Z) Should not be Empty.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF25', N'collapseFour-txt12DAmount', N'Box 12DSee Instruction', N'Income', N'Wages',  N'Error', N'RF', N'Box 12D See Instruction Code selected and amount is Missing', N' Form W2 from <Employer Name>: Box 12D See instruction Code 12---(A to Z) Should not be Empty.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12D See instruction Code 12---(A to Z) Should not be Empty.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF26', N'collapseSeven-txtHouseholdEmployeeWages', N'Household Employee Wages', N'Income', N'Wages',  N'Error', N'RF', N'Missing Household employee wages', N'<Employer Name>:  You have missed out to enter the Household Employee Wages', N'/Income/W2.html', N'<Employer Name>:  You have missed out to enter the Household Employee Wages', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V7', N'collapseEight-txtInstitutionZip', N'ZipCode', N'Income', N'Wages',  N'Error', N'V', N'Invalid Zip Code', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF27', N'collapseEight-txtInstitutionName', N'Institution Name', N'Income', N'Wages',  N'Error', N'RF', N'Missing Institution name', N'You have missed out to enter the Institution Name', N'/Income/W2.html', N'You have missed out to enter the Institution Name', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V8', N'collapseEight-txtInstitutionName', N'Institution Name', N'Income', N'Wages',  N'Error', N'V', N'Special Characters on Institution name', N'Institution Name - Use only Alphabets (No Special Characters, Numbers & Punctuations).', N'/Income/W2.html', N'Institution Name - Use only Alphabets (No Special Characters, Numbers & Punctuations).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF28', N'collapseEight-txtInstitutionAddress', N'Address', N'Income', N'Wages',  N'Error', N'RF', N'Missing Institution Address', N'<Instituion Name>: You have missed out to enter the Institution address.', N'/Income/W2.html', N'<Instituion Name>: You have missed out to enter the Institution address.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V9', N'collapseEight-txtInstitutionAddress', N'Address', N'Income', N'Wages',  N'Error', N'V', N'Special Character on Institution Address', N'<Instituion Name> Address - Use only Alphabets (No Special Characters, Numbers & Punctuations)', N'/Income/W2.html', N'<Instituion Name> Address - Use only Alphabets (No Special Characters, Numbers & Punctuations)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF29', N'collapseEight-txtInstitutionCity', N'City', N'Income', N'Wages',  N'Error', N'RF', N'Missing Institution City name', N'You have missed out to enter the Institution City Name', N'/Income/W2.html', N'You have missed out to enter the Institution City Name', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V10', N'collapseEight-txtInstitutionCity', N'City', N'Income', N'Wages',  N'Error', N'V', N'Special character on Institution City Name', N'<Instituion Name> City  - Use only Alphabets (No Special Characters, Numbers & Punctuations).', N'/Income/W2.html', N'<Instituion Name> City  - Use only Alphabets (No Special Characters, Numbers & Punctuations).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF30', N'collapseEight-ddlInstitutionState', N'State Code', N'Income', N'Wages',  N'Error', N'RF', N'Missing Institution State Code', N'<Instituion Name>: You have missed out to select the Institution State Code', N'/Income/W2.html', N'<Instituion Name>: You have missed out to select the Institution State Code', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF31', N'collapseEight-ddlInstitutionState', N'Zip Code', N'Income', N'Wages',  N'Error', N'RF', N'Missing Zip Code', N'<Institution Name>: You have missed out to enter the Institution Zip Code', N'/Income/W2.html', N'<Institution Name>: You have missed out to enter the Institution Zip Code', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF32', N'collapseEight-txtTaxableScholarshipAmount', N'Taxable Scholarship', N'Income', N'Wages',  N'Error', N'RF', N'Missing Taxable Scholarship', N'<Institution Name>: Taxable scholarship amount should not be Empty', N'/Income/W2.html', N'<Institution Name>: Taxable scholarship amount should not be Empty', 0)
--Yogalakshmi - 20th June 2014 - Changed the focus name.
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER9', N'collapseNine-radYes', N'Foreign Employment compensation', N'Income', N'Wages',  N'Error', N'ER', N'You must report your Foreign employment compensation on  FEC record for Electronic Filing.', N'You must report your Foreign employment compensation on  FEC record for Electronic Filing. And this program doesn''t support this Form.', N'/Income/W2.html',N'You must report your Foreign employment compensation on  FEC record for Electronic Filing. And this program doesn''t support this Form.', 0)
--Yogalakshmi - 30th May 2014 - Added some Error Messages
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR10', N'collapseSeven-txtHouseholdEmployeeWages', N'Household Employee Wages', N'Income', N'Wages',  N'Error', N'BR', N'Your Household employee wages should not be greater than $1,800. Check your entry.', N'Your Household employee wages should not be greater than $1,800. Check your entry.', N'/Income/W2.html', N'Your Household employee wages should not be greater than $1,800. Check your entry.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF33', N'collapseThree-txtW2SSWages', N'Box  3 Social Security Wages', N'Income', N'Wages',  N'Error', N'BR', N'Missing Social security Wages', N'You have missed out to enter Social Security Wages. If none, enter Zero.', N'/Income/W2.html', N'You have missed out to enter Social Security Wages. If none, enter Zero.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF34', N'collapseThree-txtW2SSwithheld', N'Box 4 Social Security Tax Withheld', N'Income', N'Wages',  N'Error', N'BR', N'Missing Social security tax withheld', N'You have missed out to enter Social Security tax withheld. If none, enter Zero.', N'/Income/W2.html', N'You have missed out to enter Social Security tax withheld. If none, enter Zero.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF35', N'collapseThree-txtW2MedicalWages', N'Box 5  Medicare Wages', N'Income', N'Wages',  N'Error', N'BR', N'Missing Medicare wages', N'You have missed out to enter Medicare Wages. If none, enter Zero.', N'/Income/W2.html', N'You have missed out to enter Medicare Wages. If none, enter Zero.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF36', N'collapseThree-txtW2MedicalWithheld', N'Box 6 Medicare Tax Withheld', N'Income', N'Wages',  N'Error', N'BR', N'Missing Medicare tax withheld', N'You have missed out to enter Medicare tax withheld. If none, enter Zero.', N'/Income/W2.html', N'You have missed out to enter Medicare tax withheld. If none, enter Zero.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF37', N'collapseFour-ddlW212A', N'Box 12A (See Instruction for Box 12)', N'Income', N'Wages',  N'Error', N'BR', N'Missing Box 12A benefits code', N'Form W2 from <Employer Name>: You have not Selected  Box 12A benefits code.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have not Selected  Box 12A benefits code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF38', N'collapseFour-ddlW212B', N'Box 12B(See Instruction for Box 12)', N'Income', N'Wages',  N'Error', N'BR', N'Missing Box 12B benefits code', N'Form W2 from <Employer Name>: You have not Selected  Box 12B benefits code.', N'/Income/W2.html', N' Form W2 from <Employer Name>: You have not Selected  Box 12B benefits code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF39', N'collapseFour-ddlW212C', N'Box 12C(See Instruction for Box 12)', N'Income', N'Wages',  N'Error', N'BR', N'Missing Box 12C benefits code', N'Form W2 from <Employer Name>: You have not Selected  Box 12C benefits code.', N'/Income/W2.html', N' Form W2 from <Employer Name>: You have not Selected  Box 12C benefits code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF40', N'collapseFour-ddlW212D', N'Box 12D(See Instruction for Box 12)', N'Income', N'Wages',  N'Error', N'BR', N'Missing Box 12D benefits code', N'Form W2 from <Employer Name>: You have not Selected  Box 12D benefits code.', N'/Income/W2.html', N' Form W2 from <Employer Name>: You have not Selected  Box 12D benefits code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF41', N'collapseFour-txtW2Amount0', N'Other Information', N'Income', N'Wages',  N'Error', N'BR', N'Missing Description for other benefits amount.', N'Form W2 from <Employer Name>:  You have not entered the description for other benfits amount.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have not entered the description for other benfits amount.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V11', N'collapseSeven-txtHouseholdEmployerName', N'Employer Name', N'Income', N'Wages',  N'Error', N'BR', N'Special characters on Employer Name', N'Employer Name - Use only Alphabets and Numbers (No Special Character & Punctuations).', N'/Income/W2.html', N'Employer Name - Use only Alphabets and Numbers (No Special Character & Punctuations).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V12', N'collapseSeven-txtHouseholdEmployerAddress', N'Employer Address', N'Income', N'Wages',  N'Error', N'BR', N'Special characters on Employer Address', N'Form W2 from <Employer Name> Address -Use only Alphabets and Numbers (No Special Character & Punctuations).', N'/Income/W2.html', N'Form W2 from <Employer Name> Address -Use only Alphabets and Numbers (No Special Character & Punctuations).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V13', N'collapseSeven-txtHouseholdEmployerCity', N'Employer City', N'Income', N'Wages',  N'Error', N'BR', N'Special characters on Employer city Name', N'Form W2 from <Employer Name> City - Use only Alphabets (No Special Characters, Numbers & Punctuations).', N'/Income/W2.html', N'Form W2 from <Employer Name> City - Use only Alphabets (No Special Characters, Numbers & Punctuations).', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V14', N'collapseOne-txtW2EmployerZip', N'Employer Zip Code', N'Income', N'Wages',  N'Error', N'BR', N'Invalid Zip Code', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V15', N'collapseSeven-txtHouseholdEmployerZip', N'Employer Zip Code', N'Income', N'Wages',  N'Error', N'BR', N'Invalid Zip Code', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V16', N'collapseEight-txtInstitutionZip', N'State', N'Income', N'Wages',  N'Error', N'BR', N'Invalid Zip Code', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_V17', N'collapseTwo-txtW2EmployeeZip', N'Employee Zip Code', N'Income', N'Wages',  N'Error', N'BR', N'Invalid Zip Code', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have entered an Invalid Zip Code. Please enter a Valid Zip Code', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF42', N'collapseSeven-txtHouseholdEmployerName', N'Employer Name', N'Income', N'Wages',  N'Error', N'BR', N'Missing Employer Name', N' You have missed out the Employer Name.', N'/Income/W2.html', N' You have missed out the Employer Name.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF43', N'collapseSeven-txtHouseholdEmployerAddress', N'Employer Address', N'Income', N'Wages',  N'Error', N'BR', N'Missing Employer Address', N'Form W2 from <Employer Name>: You have missed out the Employer Address.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out the Employer Address.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF44', N'collapseSeven-txtHouseholdEmployerCity', N'Employer City', N'Income', N'Wages',  N'Error', N'BR', N'Missing Employer City Name', N'Form W2 from <Employer Name>: You have missed out the Employer City Name.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out the Employer City Name.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF45', N'collapseSeven-ddlHouseholdEmployerState', N'Employer State', N'Income', N'Wages',  N'Error', N'BR', N'Missing Employer State', N'Form W2 from <Employer Name>: You have missed out to Select the Employer State Code.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out to Select the Employer State Code.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_RF46', N'collapseSeven-txtHouseholdEmployerZip', N'Employer Zip Code', N'Income', N'Wages',  N'Error', N'BR', N'Missing Employer Zip Code', N'Form W2 from <Employer Name>: You have missed out the Employer Zip Code.', N'/Income/W2.html', N'Form W2 from <Employer Name>: You have missed out the Employer Zip Code.', 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR11', N'collapseFour-ddlW212B', N'Box 12R  Employer contributions to an Archer Medical Savings Account.', N'Income', N'Wages',  N'Error', N'BR', N' Box 12R Employer contribution to an Archer Medical savings Account amount must be reported on Form 8853.', N' Form W2 from <Employer Name>: Box 12R Employer contribution to an Archer Medical savings Account amount must be reported  on Form 8853. And this program doesnt support this form.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12R Employer contribution to an Archer Medical savings Account amount must be reported  on Form 8853. And this program doesnt support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR12', N'collapseFour-ddlW212B', N'Box 12T Employer paid adoption benefits.', N'Income', N'Wages',  N'Error', N'BR', N' Box 12T Employer paid adoption benefits amount must be reported on Form 8839.', N'Form W2 from <Employer Name>: Box 12T Employer paid adoption benefits amount must be reported on Form 8839. This program doesnt support this form.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12T Employer paid adoption benefits amount must be reported on Form 8839. This program doesnt support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR13', N'collapseFour-ddlW212B', N'Box12W Employer and employee contributions to a Health Savings Account.', N'Income', N'Wages',  N'Error', N'BR', N'  Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889', N'Form W2 from <Employer Name>: Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889.This program dont support this form.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889.This program dont support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR14', N'collapseFour-ddlW212C', N'Box 12R  Employer contributions to an Archer Medical Savings Account.', N'Income', N'Wages',  N'Error', N'BR', N' Box 12R Employer contribution to an Archer Medical savings Account amount must be reported on Form 8853.', N' Form W2 from <Employer Name>: Box 12R Employer contribution to an Archer Medical savings Account amount must be reported  on Form 8853. And this program doesnt support this form.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12R Employer contribution to an Archer Medical savings Account amount must be reported  on Form 8853. And this program doesnt support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR15', N'collapseFour-ddlW212C', N'Box 12T Employer paid adoption benefits.', N'Income', N'Wages',  N'Error', N'BR', N' Box 12T Employer paid adoption benefits amount must be reported on Form 8839.', N'Form W2 from <Employer Name>: Box 12T Employer paid adoption benefits amount must be reported on Form 8839. This program doesnt support this form.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12T Employer paid adoption benefits amount must be reported on Form 8839. This program doesnt support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR16', N'collapseFour-ddlW212C', N'Box12W Employer and employee contributions to a Health Savings Account.', N'Income', N'Wages',  N'Error', N'BR', N'  Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889', N'Form W2 from <Employer Name>: Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889.This program dont support this form.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889.This program dont support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR17', N'collapseFour-ddlW212D', N'Box 12R  Employer contributions to an Archer Medical Savings Account.', N'Income', N'Wages',  N'Error', N'BR', N' Box 12R Employer contribution to an Archer Medical savings Account amount must be reported on Form 8853.', N' Form W2 from <Employer Name>: Box 12R Employer contribution to an Archer Medical savings Account amount must be reported  on Form 8853. And this program doesnt support this form.', N'/Income/W2.html', N' Form W2 from <Employer Name>: Box 12R Employer contribution to an Archer Medical savings Account amount must be reported  on Form 8853. And this program doesnt support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR18', N'collapseFour-ddlW212D', N'Box 12T Employer paid adoption benefits.', N'Income', N'Wages',  N'Error', N'BR', N' Box 12T Employer paid adoption benefits amount must be reported on Form 8839.', N'Form W2 from <Employer Name>: Box 12T Employer paid adoption benefits amount must be reported on Form 8839. This program doesnt support this form.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12T Employer paid adoption benefits amount must be reported on Form 8839. This program doesnt support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_BR19', N'collapseFour-ddlW212D', N'Box12W Employer and employee contributions to a Health Savings Account.', N'Income', N'Wages',  N'Error', N'BR', N'  Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889', N'Form W2 from <Employer Name>: Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889.This program dont support this form.', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12W Employer and employee contributions to a Health Savings Account should be reported on Form 8889.This program dont support this form.', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER10', N'collapseFour-ddlW212B', N'Box 12A Uncollected Social Security or RRTA Tax on Tips.', N'Income', N'Wages',  N'Error', N'ER', N'Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60', N' Form W2 from <Employer Name>: Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER11', N'collapseFour-ddlW212B', N'Box 12B Uncollected Medicare Tax on Tips.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER12', N'collapseFour-ddlW212B', N'Box 12K Excise Tax (equal to 20%) on excess "golden parachute" payments.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER13', N'collapseFour-ddlW212B', N'Box 12M Uncollected Social Security or RRTA Tax on Taxable group term life insurance over $50,000 for former employees', N'Income', N'Wages',  N'Error', N'ER', N'Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040  Line 60 other Taxes ', N'Form W2 from <Employer Name>: Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on FormA 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on FormA 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER14', N'collapseFour-ddlW212B', N'Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER15', N'collapseFour-ddlW212B', N'Box12Z Income received under 409A non-qualified deferred compensation plan.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040  Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER16', N'collapseFour-ddlW212C', N'Box 12A Uncollected Social Security or RRTA Tax on Tips.', N'Income', N'Wages',  N'Error', N'ER', N'Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60', N' Form W2 from <Employer Name>: Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER17', N'collapseFour-ddlW212C', N'Box 12B Uncollected Medicare Tax on Tips.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER18', N'collapseFour-ddlW212C', N'Box 12K Excise Tax (equal to 20%) on excess "golden parachute" payments.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER19', N'collapseFour-ddlW212C', N'Box 12M Uncollected Social Security or RRTA Tax on Taxable group term life insurance over $50,000 for former employees', N'Income', N'Wages',  N'Error', N'ER', N'Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040  Line 60 other Taxes ', N'Form W2 from <Employer Name>: Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on FormA 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on FormA 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER20', N'collapseFour-ddlW212C', N'Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER21', N'collapseFour-ddlW212C', N'Box12Z Income received under 409A non-qualified deferred compensation plan.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040  Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER22', N'collapseFour-ddlW212D', N'Box 12A Uncollected Social Security or RRTA Tax on Tips.', N'Income', N'Wages',  N'Error', N'ER', N'Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60', N' Form W2 from <Employer Name>: Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER23', N'collapseFour-ddlW212D', N'Box 12B Uncollected Medicare Tax on Tips.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER24', N'collapseFour-ddlW212D', N'Box 12K Excise Tax (equal to 20%) on excess "golden parachute" payments.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER25', N'collapseFour-ddlW212D', N'Box 12M Uncollected Social Security or RRTA Tax on Taxable group term life insurance over $50,000 for former employees', N'Income', N'Wages',  N'Error', N'ER', N'Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040  Line 60 other Taxes ', N'Form W2 from <Employer Name>: Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on FormA 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on FormA 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER26', N'collapseFour-ddlW212D', N'Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)', 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'Wages_ER27', N'collapseFour-ddlW212D', N'Box12Z Income received under 409A non-qualified deferred compensation plan.', N'Income', N'Wages',  N'Error', N'ER', N'Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040  Line 60 other Taxes.', N'Form W2 from <Employer Name>: Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', N'/Income/W2.html', N'Form W2 from <Employer Name>: Box 12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)', 0)

-- Added By saravanan on 3-6-2014
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF1', N'divWhoseInterest-rdInterestIncomeSelect', N'Whose 1099INT is this',  N'Income', N'FormINT', N'Error', N'RF', N'Missing Taxpayer or Spouse Code.', N'You have missed out to select the Taxpayer or Spouse Code.', N'/Income/InterestIncome.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF2', N'div-txtpayername', N'Payer Name',  N'Income', N'FormINT', N'Error', N'RF', N'Payer Name should not be Empty.', N'Payer Name Should not be Empty.', N'/Income/InterestIncome.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF3', N'collapseOne-txtInterestIncome', N'Interest Income',  N'Income', N'FormINT', N'Error', N'RF', N'Missing Box 1 Interest Income or Box 3 U.S saving Bond Interest', N'1099 INT/OID from {0}: Box 1 Interest Income or Box 3 U.S saving Bond Interest Income should not be Empty.', N'/Income/F1099INT.html', NULL, 0)

-- Defect TAX1040-14000 - vivek on 10-jun-14 - Control name altered.
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF4', N'collapseThree-ddlStateExemptCode', N'Tax exempt Interest',  N'Income', N'FormINT', N'Error', N'RF', N'Missing State Code and State exempt amount', N'1099 INT/OID from {0}: You have missed out the State Code and State exempt amount for Box 8 Tax exempt Interest.', N'/Income/F1099INT.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF5', N'collapseOne-txtOriginalIssueDiscount', N'Original Issue Discount',  N'Income', N'FormOID', N'Error', N'RF', N'Missing Box 1 Original Issue Discount, Box 2 other periodical Interest and Box 8 OID Interest on U.S saving bonds', N'1099 INT/OID from {0}: Interest Income should not be Empty.', N'/Income/F1099OID.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF6', N'collapseTwo-txttaxexempt', N'Tax exempt interest',  N'Income', N'FormOID', N'Error', N'RF', N'Missing Tax exempt Interest', N'1099 INT/OID from {0}: Tax Exempt Interest should not be Empty.', N'/Income/F1099OID.html', NULL, 0)

--Defect TAX1040-14000 - Saravanan N - 10th June, 2014 - Control name altered.
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF7', N'collapseTwo-ddlStateCode3', N'State Tax exempt Interest',  N'Income', N'FormOID', N'Error', N'RF', N'Missing State Tax exempt Interest & State Code', N'1099 INT/OID from {0}: State Code and State Tax exempt interest should not be Empty.', N'/Income/F1099OID.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF8', N'collapseTwo-txtajusment', N'OID Adjustment',  N'Income', N'FormOID', N'Error', N'RF', N'Missing OID adjustment', N'1099 INT/OID from {0}: OID adjustment should not be Empty.', N'F1099OID.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF9', N'lstInterestIncomeCheck-chkNoneAbove', N'None of the above',  N'Income', N'InterestIncome', N'Error', N'RF', N'You have missed to select  the option none of the above.', N'You have missed out to check the eligibility Criteria for Interest Income to File Form 1040EZ. If any one of the conditions is not applied to you, Please select None of the above.', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF10', N'collapseTwo-ddlStateCode', N'None of the above',  N'Income', N'FormINT', N'Error', N'RF', N'Missing State Code', N'You have missed out to select the State code', N'/Income/f1099int.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF11', N'collapseTwo-ddlPayerStateCode', N'None of the above',  N'Income', N'FormINT', N'Error', N'RF', N'Missing State Code', N'You have missed out to select the State code', N'/Income/f1099int.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF12', N'collapseTwo-ddlStateCodeID', N'None of the above',  N'Income', N'FormOID', N'Error', N'RF', N'Missing State Code', N'You have missed out to select the State code', N'/Income/f1099oid.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF13', N'collapseTwo-ddlStateCode2', N'None of the above',  N'Income', N'FormOID', N'Error', N'RF', N'Missing State Code', N'You have missed out to select the State code', N'/Income/f1099oid.html', NULL, 0)

-- INTEREST INCOME - Vincent-Added Dupiculate for FormOID
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF14', N'divWhoseInterest-rdInterestIncomeSelect', N'Whose 1099INT is this',  N'Income', N'FormOID', N'Error', N'RF', N'Missing Taxpayer or Spouse Code.', N'You have missed out to select the Taxpayer or Spouse Code.', N'/Income/InterestIncome.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_RF15', N'div-txtpayername', N'Payer Name',  N'Income', N'FormOID', N'Error', N'RF', N'Payer Name should not be Empty.', N'Payer Name Should not be Empty.', N'/Income/InterestIncome.html', NULL, 0)


--INTEREST INCOME - VALIDATIONS
--Yogalakshmi - 22nd May 2014 - Made changes as per the Spec
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_V1', N'div-txtpayername', N'Payer Name',  N'Income', N'FormINT', N'Error', N'V', N'Special Characters on Payer Name', N'{0}: Use only Alphabets (No Special Characters, Numbers & Punctuations).', N'/Income/InterestIncome.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_V2', N'div-txtpayerEIN', N'payer Identiification Number',  N'Income', N'FormINT', N'Error', N'V', N'Invalid Identification Number', N'1099 INT/OID from {0}: You have entered an Invalid Payer Identification number. Please enter a valid EIN.', N'/Income/InterestIncome.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_V3', N'div-txtpayername', N'Payer Name',  N'Income', N'FormOID', N'Error', N'V', N'Special Characters on Payer Name', N'{0}: Use only Alphabets (No Special Characters, Numbers & Punctuations).', N'/Income/InterestIncome.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_V4', N'div-txtpayerEIN', N'payer Identiification Number',  N'Income', N'FormOID', N'Error', N'V', N'Invalid Identification Number', N'1099 INT/OID from {0}: You have entered an Invalid Payer Identification number. Please enter a valid EIN.', N'/Income/InterestIncome.html', NULL, 0)

--vivek - 6-jun-14 added this message for the as per the spec
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_V5', N'collapseThree-txtExempt', N'State Tax exempt Interest',  N'Income', N'FormINT', N'Error', N'V', N'Your State tax exempt Interest amount should not be greater than Box 8 Tax Exempt Interest Income.', N'Your State tax exempt Interest Income should not be greater than Box 8 Federal tax exempt Interest.', N'/Income/F1099INT.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_V6', N'collapseTwo-txtStateExempt', N'State Tax exempt Interest',  N'Income', N'FormOID', N'Error', N'V', N'State tax exempt Interest amount should not be greater than Federal Tax Exempt Interest Income.', N'Your State tax exempt Interest Income should not be greater than Federal tax exempt Interest.', N'/Income/F1099OID.html', NULL, 0)  

--INTEREST INCOME - BUSINESS RULES
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR1', N'collapseOne-txtFederalTaxWitheld', N'Federal Tax withheld',  N'Income', N'FormINT', N'Error', N'BR', N'Box4 Federal Tax withheld should not be more than Interest Income', N'1099 INT from {0}: Box 4 Federal Tax withheld should not be more than Interest Income.', N'/Income/F1099INT.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR2', N'collapseOne-txtInvestmentExpenses', N'Investment Expenses',  N'Income', N'FormINT', N'Information', N'BR', N'Investment expenses must be reported on Schedule A.', N'1099 INTfrom {0}: Investment expenses must be reported on Form Schedule A.  By claiming Standard deduction on Form 1040EZ, Your Investment expenses cannot be itemized.', N'/Income/F1099INT.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR3', N'collapseTwo-txtStateWithheld', N'State Tax withheld',  N'Income', N'FormINT', N'Error', N'BR', N'Box 13 State Tax withheld should not be greater than Interest Income', N'1099 INT from {0}: Box 13 State Tax withheld should not be greater than Interest Income.', N'/Income/F1099INT.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR4', N'collapseOne-txtForeignWithheld', N'Foreign Tax withheld',  N'Income', N'FormINT', N'Information', N'BR', N'Foreign Tax withheld must be reported on Form 1116', N'1099 INT/OID from {0}: Your Foreign Tax credit amount of $---- must be reported on Form 1116 (if Foreign Tax credit is $300 for single and $ 600 for MFJ). And this program doesn''t support this Form.', N'/Income/F1099INT.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR5', N'collapseOne-txtEarlyWithdrawal', N'Early withdrawal Penalty',  N'Income', N'FormINT', N'Error', N'BR', N' Deduction for Early withdrawal penalty payment.', N'You can deduct your Early withdrawal penalty payment on Form 1040 under Adjusted Gross Income deduction.',N'/Income/F1099INT.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR6', N'collapseOne-txtFederalTaxWithHoldingAmount', N'Federal Tax withheld',  N'Income', N'FormOID', N'Error', N'BR', N' Box4 Federal Tax withheld should not be more than Interest Income', N'1099 OID from {0}:  Box 4 Federal Tax withheld should not be more than Interest Income.', N'/Income/F1099OID.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR7', N'collapseOne-txtInvestmentExpenses', N'Investment Expenses',  N'Income', N'FormOID', N'Information', N'BR', N' Investment expenses must be reported on Schedule A.', N'1099 OID from {0}:  Investment expenses must be reported on Form Schedule A.  By claiming Standard deduction on Form 1040EZ, Your Investment expenses cannot be itemized.', N'/Income/F1099OID.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR8', N'collapseTwo-txtStateTaxWithholdingAmount', N'State Tax withheld',  N'Income', N'FormOID', N'Error', N'BR', N' Box 13 State Tax withheld should not be greater than Interest Income', N'1099 OID from {0}:  Box 13 State Tax withheld should not be greater than Interest Income.', N'/Income/F1099OID.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR9', N'collapseOne-txtForeignTaxPaid', N'Foreign Tax withheld',  N'Income', N'FormOID', N'Information', N'BR', N' Foreign Tax withheld must be reported on Form 1116', N'1099 INT/OID from {0}:  Your Foreign Tax credit amount of $---- must be reported on Form 1116 (if Foreign Tax credit is $300 for single and $ 600 for MFJ). And this program doesnt support this Form.', N'/Income/F1099OID.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_BR10', N'collapseOne-txtEarlyWithdrawalPenalty', N'Early withdrawal Penalty',  N'Income', N'FormOID', N'Error', N'BR', N' Deduction for Early withdrawal penalty payment.', N'You can deduct your Early withdrawal penalty payment on Form 1040 under Adjusted Gross Income deduction.', N'/Income/F1099OID.html', NULL, 0)


--Interest Income error messag

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER1', N'lstInterestIncomeCheck-chkNomineeInterest', N'Nominee Interest',  N'Income', N'InterestIncome', N'Error', N'ER', N'Your Taxable Interest Income should not be Nominee Interest income', N'Your Taxable Interest Income should not be Nominee Interest income', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER2', N'lstInterestIncomeCheck-chkUSSavingBond', N'US Bond Savings Interest Income',  N'Income', N'InterestIncome', N'Error', N'ER', N'Your 1099INT US saving bond Interest income should not include the amount reported before 2014', N'Your 1099INT US saving bond Interest income should not include the amount reported before 2014', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER3', N'lstInterestIncomeCheck-chkForeignFinancial', N'Foreign Financial Account',  N'Income', N'InterestIncome', N'Error', N'ER', N'You should not own any Foreign Financial account such as bank account with combined value over $10,000 at any time during 2014.', N'You Should not Own any Foreign Financial Accounts such as Bank account with combined value more $10,000 .', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER4', N'lstInterestIncomeCheck-chkSellerMortgage', N'Seller Finance Mortgage Interest',  N'Income', N'InterestIncome', N'Error', N'ER', N'Your Interest income should not be from Seller Finance Mortgage Property.', N'Your Interest Income Should not be from Seller Finance Mortgage property.', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER5', N'lstInterestIncomeCheck-chkOrginalIssueDiscount', N'Original Issue Discount',  N'Income', N'InterestIncome', N'Error', N'ER', N'Your OID Interest Income should not be less than the amount reported on 1099OID.', N'Your OID Interest Income should not be less than the amount reported on 1099OID.', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER6', N'lstInterestIncomeCheck-chkAmortizable', N'Amortizable Bond premium',  N'Income', N'InterestIncome', N'Error', N'ER', N'Your Interest Income should not be reduced by amortizable Bond Premium.', N'Your Interest Income should not be reduced by amortizable Bond Premium.', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER7', N'lstInterestIncomeCheck-chkEEorUS', N'series EE or I U.S. savings bonds',  N'Income', N'InterestIncome', N'Error', N'ER', N'You should not claim Exclusion of Interest from U.S series EE or I savings bonds in 2014 that were issued after 1989.', N'You should not claim Exclusion of Interest from U.S series EE or I savings bonds in 2014 that were issued after 1989.', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER8', N'lstInterestIncomeCheck-chkEarlyPenalty', N'Early withdrawal Penalty',  N'Income', N'InterestIncome', N'Error', N'ER', N'Your Adjusted gross Income deduction of Early withdrawal penalty is not deductible.', N' 1099 INT/OID from {0}: You have to claim adjusted gross Income deduction for Early withdrawal penalty.', N'/Income/InterestIncomeCheckList.html', NULL, 0)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER9', N'lstInterestIncomeCheck-chkForeignTaxCredit', N'Foreign Tax withheld',  N'Income', N'InterestIncome', N'Error', N'ER', N'Foreign Tax credit is not allowed', N'1099 INT/OID from {0}: You have to claim Credit for Foreign Taxes paid to other country. ',N'/Income/InterestIncomeCheckList.html', NULL, 0)

-- Saravanan N - 2nd June, 2014
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'InterestIncome_ER10', N'collapseOne-txtInterestIncome', N'Total Interest Income',  N'Income', N'InterestIncome', N'Error', N'ER', N' Your Taxable Interest Income on Form 1040EZ (Line 2) should be less than $1,500.', N'Your Taxable Interest Income on Form 1040EZ (Line 2) should be less than $1,500.', N'/Income/InterestIncomeSummary.html', NULL, 0)

--UnEmployment error message

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF1', N'collapseOne-radPrimaryTaxPayer', N'Whose Unemployment compensation is this',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Taxpayer or Spouse Code.', N'You have missed out to select the Taxpayer or Spouse Code', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF2', N'collapseOne-txtF1099GPayerName', N'Payer Name',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Payer Name', N'Payer Name Should not be Empty', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF3', N'collapseOne-txtF1099GPayerAddress', N'Payer Address',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Payer Address', N'{0} Address should not be Empty.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF4', N'collapseOne-txtF1099GPayerCity', N'Payer City',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Payer City', N'{0} City should not be Empty.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF5', N'collapseOne-ddlF1099GState', N'Payer State Info',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Payer State Code', N'{0} You have missed out to select the Payer State Code', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF6', N'collapseOne-txtF1099GPayerZip', N'Payer Zip Code',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Payer Zip Code', N'{0} Payer Zip Code should not be Empty.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF7', N'collapseOne-txtPayerIdentificationNumber', N'Payer''s Identification Number',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Payer''s Identification Number', N'{0} Identification number should not be Empty', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF8', N'collapseTwo-txtF1099GUnempCompReceived', N'Unemployment Compensation amount',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Unemployment Compensation benefit', N'{0} Box 1 Unemployment Compensation received should not be Empty.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF9', N'collapseTwo-txtF1099GFederaltaxWithheld', N'Box 4 Federal Tax withheld',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Box 4 Federal Tax withheld', N'{0} Box 4 Federal Tax withheld should not be Empty.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF10', N'collapseTwo-txtRepaidAmountCurrentYear', N'Repaid amount',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Repaid amount', N'{0} Repaid amount of Unemployment Compensation should not be Empty.', N'/Income/Unemployment.html', NULL, 0)
--Yogalkashmi - 29th May 2014 - Added two new error messages(RF11 and RF12) as per the modified SPEC.
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF11', N'collapseTwo-txtRepaidAmountPriorYear', N'Repaid amount',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing Repaid amount', N'{0} Repaid amount of Unemployment Compensation should not be Empty.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_RF12', N'collapseTwo-ddlF1099GEmployerState1', N'Box 10a State Code',  N'Income', N'UnemploymentCompensation', N'Error', N'RF', N'Missing State Code', N'{0} You have missed out to select the State code', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_V1', N'collapseOne-txtF1099GPayerName', N'Payer Name',  N'Income', N'UnemploymentCompensation', N'Error', N'V', N'Special Characters on Payer Name', N'{0}- Use only Alphabets (No Special Characters, Numbers & Punctuations)', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_V2', N'collapseOne-txtF1099GPayerAddress', N'Payer Address',  N'Income', N'UnemploymentCompensation', N'Error', N'V', N'Special Characters on Payer Address', N'{0} Payer Address- Use only Alphabets (No Special Characters, Numbers & Punctuations)', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_V3', N'collapseOne-txtF1099GPayerCity', N'Payer City',  N'Income', N'UnemploymentCompensation', N'Error', N'V', N'Special Character on Payer City', N'{0}- Use only Alphabets (No Special Characters, Numbers & Punctuations)', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_V4', N'collapseOne-txtF1099GPayerZip', N'Payer Zip Code',  N'Income', N'UnemploymentCompensation', N'Error', N'V', N'Invalid Zip Code', N'{0} You have entered an Invalid Zip Code. Please enter a Valid Zip Code.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_V5', N'collapseOne-txtPayerIdentificationNumber', N'Payer''s Identification Number',  N'Income', N'UnemploymentCompensation', N'Error', N'V', N'Invalid Payer''s Identification Number', N'{0} You have entered an Invalid Payer''s identification Number. Please enter a valid Identification Number.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_BR1', N'collapseTwo-txtF1099GFederaltaxWithheld', N'Box 4 Federal Tax withheld',  N'Income', N'UnemploymentCompensation', N'Error', N'BR', N'Box 4 Federal Tax withheld should not be greater than box 1 Unemployment compensation.', N'{0} Box 4 Federal Tax withheld should not be greater than box 1 Unemployment Compensation.', N'/Income/Unemployment.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_BR2', N'collapseTwo-txtF1099GStateTaxWithheld2', N'Box11 State Tax withheld',  N'Income', N'UnemploymentCompensation', N'Error', N'BR', N'Box 11 State Tax withheld should not be greater than box 1 Unemployment compensation. ', N'{0} Box 11 State Tax withheld should not be greater than box 1 Unemployment compensation. ', N'/Income/Unemployment.html', NULL, 0)
--27Jun2014 Sathish corrected field name for diagnotics navigation : # TAX1040-14063 
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'UnemploymentCompensation_ER1', N'collapseTwo-txtRepaidAmountPriorYear', N'Repaid amount',  N'Income', N'UnemploymentCompensation', N'Error', N'ER', N'Repaid Unemployment benefit amount for earlier Year.', N'{0} Repayment of earlier year Unemployment Compensation benefits Should not be deducted on Form 1040EZ.', N'/Income/Unemployment.html', NULL, 0)

--Other Income error message
--Vincent- 19th Jun 2014 - Made changes in Field name for focus methed in other income.
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_RF1', N'collapseOne-txtTaxPayerNetBenefitSSB', N'Net Benefits',  N'Income', N'SSB&RRB', N'Error', N'RF', N'Missing Social security or Railroad benefits', N'Box 5 Net Benefits should not be Empty', N'/Income/OtherIncome.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_RF2', N'collapseTwo-txtAlaskaTaxPayer', N'Alaska Dividend',  N'Income', N'Alaska', N'Error', N'RF', N'Missing Alaska Dividend Income', N'Alaska Dividend Income should not be Empty.', N'/Income/OtherIncome.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_RF3', N'collapseThree-radclaimItemizedYes', N'Itemized prior year',  N'Income', N'State&local', N'Error', N'RF', N'Missing Itemized deduction claim on prior year', N'You have missed out to select that you have claimed Itemized deductions on prior year or not.', N'/Income/OtherIncome.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_RF4', N'collapseThree-radDeductStateNo', N'State or Local tax deduction',  N'Income', N'State&local', N'Error', N'RF', N'Missing State & Local tax deduction', N'You have missed out to Select the Prior year State& Local taxes deducted on Itemized deduction.', N'/Income/OtherIncome.html', NULL, 0)
 --Yogalakshmi - 22nd May 2014 - Removed RF5 and RF6 as per the Spec.(It was tax state refund).
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_BR1', N'collapseOne-txtTaxPayerFederalTaxSSB', N'Federal Tax withheld',  N'Income', N'SSB&RRB', N'Error', N'BR', N' Box 6 Federal Tax withheld should not be greater than Box 5 net benefits amount.', N' Box 6 Federal Tax withheld should not be greater than Box 5 net benefits amount.', N'/Income/OtherIncome.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_BR2', N'collapseOne-txtTaxPayerFederalRRB', N'Federal Tax withheld',  N'Income', N'SSB&RRB', N'Error', N'BR', N'Box 10 Federal Tax withheld should not be greater than Box 5 net tier benefits amount.', N'Box 10 Federal Tax withheld should not be greater than Box 5 net tier benefits amount.', N'/Income/OtherIncome.html', NULL, 0)
--Vincent- Added a duplicated code for Spouse SSB & RRB
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_BR3', N'collapseOne-txtSpouseFederalTaxSSB', N'Federal Tax withheld',  N'Income', N'SSB&RRB', N'Error', N'BR', N' Box 6 Federal Tax withheld should not be greater than Box 5 net benefits amount.', N' Box 6 Federal Tax withheld should not be greater than Box 5 net benefits amount.', N'/Income/OtherIncome.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_BR4', N'collapseOne-txtSpouseFederalRRB', N'Federal Tax withheld',  N'Income', N'SSB&RRB', N'Error', N'BR', N'Box 10 Federal Tax withheld should not be greater than Box 5 net tier benefits amount.', N'Box 10 Federal Tax withheld should not be greater than Box 5 net tier benefits amount.', N'/Income/OtherIncome.html', NULL, 0)
--Vincent- 2 Jun 2014- Added the field name to focus
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_ER1', N'collapseThree-dvYesStateDeduct', N'State Tax refund',  N'Income', N'OtherIncome', N'Error', N'ER', N'Taxable State Tax refund Income', N'You have taxable State or Local tax refund. You have to report your tax refund on Form 1040A or Form 1040.', N'/Income/OtherIncome.html', NULL, 0)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title], [is_deleted]) VALUES (N'OtherIncome_ER2', N'collapseOne-txtTaxPayerNetBenefitSSB', N'Taxable Social Security & Railroad Benefits',  N'Income', N'OtherIncome', N'Error', N'ER', N'Taxable Social Security and Railroad benefits', N' You & your Spouse (if MFJ) should not have any Taxable social security Benefits or Railroad benefits Income on your Tax return.',  N'/Income/OtherIncome.html', NULL, 0)


/* 04Apr2014 Sathish Add new error message for EIC */
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES(	'EarnedIncomeCredit_BR1','EIC  - AGI exceed $14,340 Single','AGI exceeds - $14,340 Single ','Credit','EarnedIncomeCredit','Information','BR','Your Earned Income (------) and Adjusted Gross Income (----) exceeds the maximum allowed amount of $14,340 with no qualifying children.','Your Earned Income (------) and Adjusted Gross Income {0} exceeds the maximum allowed amount of $14,340 with no qualifying children.','','')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES(	'EarnedIncomeCredit_BR2','EIC  - AGI exceed $19,680','AGI exceeds - $19,680  MFJ','Credit','EarnedIncomeCredit','Information','BR',' Your Earned Income (------) and Adjusted Gross Income (----) exceeds the maximum allowed of $19,680 with no qualifying children. ',' Your Earned Income (------) and Adjusted Gross Income (----) exceeds the maximum allowed amount of $19,680 with no qualifying children. ','','')

/*01Jul2014 Sathish Corrrected error message for navigation from summary */
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR3','collapseOne-chkHasValidSSN','EIC -  Invalid SSN','Credit','EarnedIncomeCredit','Information','BR','You & Your Spouse (if MFJ) should not have a Valid Social security Number','You & Your Spouse should not have a Valid Social security Number.','','/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR4','EIC - Age of the Taxpayer & Spouse not less than 25 or more than 65',' Age of the Taxpayer & Spouse not less than 25 or more than 65','Credit','EarnedIncomeCredit','Information','BR','You or Your Spouse (if MFJ) Age must be more than 25 and less than 65 years in 2014. ','You or Your Spouse Age must be more than 25 and less than 65 years in 2014. ','','')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR5','collapseOne-chkLivedInUSMoreThanHalfYear','Lived in United States more than half of the year','Credit','EarnedIncomeCredit','Information','BR','You did not stayed in united States for more than half of the year.','You did not stayed in united States for more than half of the year.','','/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR6','collapseOne-chkClaimedAsQualifiedChild','Taxpayer and Spouse should not be qualified child on another person','Credit','EarnedIncomeCredit','Information','BR','You or Your Spouse (if MFJ) claimed as a qualified child on another person return.','You or Your Spouse (MFJ) claimed as a qualified child on another person return.','','/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR7','collapseOne-chkNoticeFromIRSToClaimEIC','Received notice from IRS for not to claim EIC Credit','Credit','EarnedIncomeCredit','Information','BR',' You are prohibited by IRS that  You are not eligible to claim EIC Credit',' You are prohibited by IRS that  You are not eligible to claim EIC Credit','','/Credits/earnedincomecredits.html')
/* 01Jul2014 Sathish Add new error message for Spouse claimed as dependent */
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES(	'EarnedIncomeCredit_BR13','EIC - MFJ  Taxpayer & Spouse Spouse claimed as dependent on another return.','Taxpayer & Spouse Spouse claimed as dependent on another return.','Credit','EarnedIncomeCredit','Information','BR','You or Your Spouse (if MFJ) claimed as dependent on another return.','You or Your Spouse claimed as dependent on another return.','','')


INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES(	'EarnedIncomeCredit_BR8','EIC - MFJ  Taxpayer & Spouse Spouse claimed as dependent on another return.','Taxpayer & Spouse Spouse claimed as dependent on another return.','Credit','EarnedIncomeCredit','Information','BR','You or Your Spouse (if MFJ) claimed as dependent on another return.','You or Your Spouse claimed as dependent on another return.','','')
--Prasana Modified RF Validation for Credits
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_RF1','collapseOne-txtTaxableScholarship','EIC _ Taxable of Fellowship Income','Credit','EarnedIncomeCredit','Error','RF','You have missed out the  amount received as taxable Scholarship or Fellowship Income not reported on Form W-2','Missing amount for Taxable Scholarship or Fellowship Income',null,'/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_RF2','collapseOne-txtPensionAnnuity','EIC - Pension or annuity from a non-qualified deferred compensation ','Credit','EarnedIncomeCredit','Error','RF','You have missed out the amount received as Pension or annuity from a non-qualified deferred compensation plan Income not reported on Form W-2','Missing amount for Pension or annuity from a non-qualified deferred compensation',null,'/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_RF3','collapseOne-txtInmateWages','EIC -wAges for work done while an inmate in a penal institution','Credit','EarnedIncomeCredit','Error','RF','You have missed out the amount received as wages for work has done while an inmate in a penal institution','Missing amount for wages for work done while an inmate in a penal institution',null,'/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_RF4','collapseTwo-radEICforPriorYearDisallowanceYes','EIC _ Taxable of Fellowship Income','Credit','EarnedIncomeCredit','Error','RF','Check that You like to claim EarnedIncomeCredit for Prior year disallowance ','Selection of Prior year disallowance of EIC Missing',null,'/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_RF5','collapseTwo-radIncorrectlyReportedEarnedIncomeYes','EIC _ Taxable of Fellowship Income','Credit','EarnedIncomeCredit','Error','RF','Check that Your EIC was reduced or disallowed in earlier year is because of Incorrectly reported Income.','Selection of Prior year EIC was reduced or disallowed in earlier year because of Incorrect Income is Missing',null,'/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_RF6','collapseTwo-txtNoOfDaysTaxPayerLivedInUS','EIC _ Taxable of Fellowship Income','Credit','EarnedIncomeCredit','Error','RF','Number of Days lived in United States for Taxpayer is Missing','Number of Days lived in United States for Taxpayer is Missing',null,'/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_RF7','collapseTwo-txtNoOfDaysSpouseLivedInUS','EIC _ Taxable of Fellowship Income','Credit','EarnedIncomeCredit','Error','RF','Number of Days lived in United States for Spouse is Missing','Number of Days lived in United States for Spouse is Missing',null,'/Credits/earnedincomecredits.html')
/*01Jul2014 Sathish Corrrected error message for navigation from summary */
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR9','collapseTwo-radEICforPriorYearDisallowanceYes','EarnedIncomeCredit was reduced or disallowed due to Math or clerical Error','Credit','EarnedIncomeCredit','Warning','BR',' The Form 8862 is used to report EarnedIncomeCredit was reduced or disallowed for any reason other than a math or clerical error for a year after 1996  and to claim EIC for the year.','Earned Income Credit was reduced or disallowed for any reason other than a math or clerical error','','/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR10','collapseTwo-radIncorrectlyReportedEarnedIncomeYes','EIC was reduced or disallowed in the earlier year was because of Incorrectly reported the  Earned  or Investment Income.','Credit','EarnedIncomeCredit','Warning','BR','The only reason Your EIC was reduced or disallowed in an earlier year was because You incorrectly reported Your Earned Income or Investment Income, You do not complete the rest of this form. You must attach this Form 8862 to Your tax return to take the EIC.',' EIC was reduced or disallowed in an earlier year was because You incorrectly reported Your Earned Income or Investment Income','','/Credits/earnedincomecredits.html')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR11','TP Number of Days during 2014 lived in the United States.','The Number of Days during 2014 that Taxpayer ived in the United States.','Credit','EarnedIncomeCredit','Error','BR','Number of Days lived in United States for Taxpayer is Missing','Number of Days lived in United States for Taxpayer is Missing','','')
INSERT [dbo].[error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[long_error_text],[short_error_text],[error_title],[message_target])  VALUES('EarnedIncomeCredit_BR12','SP Number of Days during 2014 lived in the United States.','The Number of Days during 2014 that  Spouse lived in the United States.','Credit','EarnedIncomeCredit','Error','BR','Number of Days lived in United States for Spouse is Missing','Number of Days lived in United States for Spouse is Missing','','')


/* 29 Apr 2014 vivek Add new error message for Tax And Wrap up*/
/* 04 Jun 2014 Bala modified insert query to add the path fr controls*/
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_ER1', N'chkHouseHoldWages', N'Taxpayer not to claim any Household employment tax', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error', N'ER', N'You & Your Spouse (if MFJ) should not subject to any household employment Taxes', N'You & Your Spouse (if MFJ) should not subject to any household employment taxes on wages paid to household employees.', N'/TaxesAndWrapUp/taxesandwrapupchecklist.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_ER2', N'chkAlternateMinimumTaxes', N'Taxpayer not to Incur any AMT & Other taxes', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error', N'ER', N'You should not subject to  Alternative minimum taxes.', N'You Should not subject to AMT(Alternative Minimum Taxes).', N'/TaxesAndWrapUp/taxesandwrapupchecklist.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_ER3', N'chkMedicareTaxes', N'Additional Social security and Medicare', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error', N'ER', N'You should not subject to any additional taxes on social security and Medicare.', N'You should not subject to any additional taxes on Social Security and Medicare.', N'/TaxesAndWrapUp/taxesandwrapupchecklist.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_ER4', N'chkFederalQuaterlyEstimatePaid', N'No estimates & Additional Federal withheld', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error', N'ER', N' You should not have made  any estimates taxes & additional withheld  for federal and State', N'You should not make any Federal, State,Local Estimates and Additional Withholding.', N'/TaxesAndWrapUp/taxesandwrapupchecklist.html', NULL)

INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_ER5', N'Taxable Income', N'Taxable Income', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'ER', N'Your taxable Income for the year should be less than $100,000.', N'Your taxable Income for the year should be less than $100,000.', N'/TaxesAndWrapUp/federaltaxsummary.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF1', N'collapseOne-txtFederalExtensionAmount', N'Extenstion amount', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error', N'RF', N'Missing Extension amount', N'You have missed out the Extension amount paid with Form 4868.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF2', N'collapseOne-txtDatePaid', N'Extension Date', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error', N'RF', N'Missing extension date', N'You have missed out to select the extension date', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF3', N'collapseOne-txtDateOfFiling', N'Filing date', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error', N'RF', N'Missing Filing date', N'You have missed out to select the Filing date', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF4', N'collapseTwo-txtBankName', N'Bank Name', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'RF', N'Missing Bank Name', N'You have missed out the Bank Name.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF5', N'collapseTwo-txtBankRoutingNumber', N'Routing Number', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'RF', N'Missing Bank Routing Number', N'Bank Routing number should not be empty.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF6', N'collapseTwo-txtBankAccountNumber', N'Account Number', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'RF', N'Missing Bank Account Number', N'Bank Account Number should not be empty.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF7', N'collapseTwo-radChecked', N'Type of Account', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'RF', N'Missing Type of Account', N'You have missed out to select the Type of account.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF8', N'collapseTwo-txtDesignName', N'Designee name', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'RF', N'Missing Designee name', N'You have missed out theThird party Designee name.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF9', N'collapseTwo-txtPhoneno', N'Designee Phone no', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'RF', N'Missing Designee Phone number', N'You have missed out theThird party Designee phone number.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF10', N'collapseTwo-txtPersonalIdentificationNumber', N'Designee Personal identification number', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'RF', N'Missing Designee personal Identification Number', N'You have missed out the Third party Designee PIN( personal Identification number).', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_V1', N'collapseTwo-txtBankRoutingNumber', N'Routing Number', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'V', N'Invalid Routing Number', N'You have entered an Invalid Routing Number. Please enter  a valid Number.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_V2', N'collapseTwo-txtBankAccountNumber', N'Account Number', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'V', N'Invalid Account number', N'You have entered an Invalid Account Number. Please enter a valid Account Number.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_V3', N'collapseTwo-txtPhoneno', N'Phone Number', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'V', N'Invalid Phone Number', N'You have entered an Invalid phone number. Please enter an valid 10 digit phone number.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)
/* 04 Jun 2014 Bala added insert query to add new validations*/
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_V7', N'collapseTwo-txtPhoneNumber', N'Phone Number', N'TaxesAndWrapUp', N'TaxesAndWrapUp', N'Error ', N'V', N'Invalid Phone Number', N'You have entered an Invalid phone number. Please enter an valid 10 digit phone number.', N'/TaxesAndWrapUp/taxesandwrapupinfo.html', NULL)

/* 27May2014 Sathish added error message for extenstion date dand filling date for spec Tax1040EZ-06_Taxes and Wrap Up _TY2014_V1 1 */
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_RF11','collapseOne-txtFederalExtensionFiledDate','Extension Filed date','TaxesAndWrapUp','TaxesAndWrapUp','Error ','RF','Missing Extension Filed date','You have missed out to enter the Extension Filed date',N'/TaxesAndWrapUp/taxesandwrapupinfo.html',null)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_V4','collapseOne-txtFederalExtensionFiledDate','Extension Filed date','TaxesAndWrapUp','TaxesAndWrapUp','Error ','V','Your Extension filed date should not be after the due date of 04/15/2015','Your Extension filed date should not be after the due date of 04/15/2015',N'/TaxesAndWrapUp/taxesandwrapupinfo.html',null)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_V5','collapseOne-txtDateOfFiling','Filing date','TaxesAndWrapUp','TaxesAndWrapUp','Error','V','Your selected filing date must be after IRS filing Due date ( 04/15/2015)','Your selected filing date must be after IRS Due date ( 04/15/2015)',N'/TaxesAndWrapUp/taxesandwrapupinfo.html',null)
INSERT [dbo].[error_message] ([error_code], [field_name], [field_description], [tab], [topic], [error_type], [message_type], [short_error_text], [long_error_text], [message_target], [error_title]) VALUES (N'TaxesAndWrapUp_V6','collapseOne-txtDatePaid','Extension date','TaxesAndWrapUp','TaxesAndWrapUp','Error','V','Your Extension payment date must be on or before IRS Filing due date.','Your Extension payment date must be on or before RS Filing due date.',N'/TaxesAndWrapUp/taxesandwrapupinfo.html',null)
GO

/* 12May2014 Ashok Kumar Error Message for payment and Efile */
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF1','Type of Account','Type of Account','File','Payment','Error','RF','Missing Type of account information.','Missing Type of account information.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF2','Account Number','Bank Account Number','File','Payment','Error','RF','Missing Bank Account number','Missing Bank Account number',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF3','Routing Number','Bank Routing Number','File','Payment','Error','RF','Missing Routing Number','Missing Routing Transit Number',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V1','Routing Number','Bank Routing Number','File','Payment','Error','V','Invalid Routing Number','You have entered an Invalid Routing Number. Please enter a valid Routing number.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF4','Name','Name of the Card Holder','File','Payment','Error','RF','Missing Card holder Name','Missing Card Holder Name',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V2','Name','Name of the Card Holder','File','Payment','Warning','V','Special Character on Name','Card Holder Name: Use only Alphabets. (No Special Characters, Numbers & Punctuations)',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF5','St. Address','Street Address','File','Payment','Error','RF','Missing Street Address','Missing Street Address Information.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V3','St. Address','Street Address','File','Payment','Warning','V','Special characters on Street Address','Street Address: Use only Alphabets (No Special Characters, Numbers & Punctuations)',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF6','City Name','City Name','File','Payment','Error','RF','Missing City Name','Missing City Name',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V4','City Name','City Name','File','Payment','Warning','V','Special characters on Street Address','City Name: Use only Alphabets (No Special Characters, Numbers & Punctuations)',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF7','State Code','State Code','File','Payment','Error','RF','Missing State Code','Select the appropriate State Code. (For instance, CA->California).',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V5','State or Province Name','State Name','File','Payment','Warning','V','Special characters on Street Address','Street Address: Use only Alphabets (No Special Characters, Numbers & Punctuations)',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF8','Zip Code','Zip Code','File','Payment','Error','RF','Missing Zip Code','Zip Code should not be empty',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V6','Zip Code','Zip Code','File','Payment','Error','V','Invalid Zip Code','You have entered an invalid Zip Code. Please check and enter.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF9','Work Phone Number','Day time Phone Number','File','Payment','Error','RF','Missing Phone Number','Missing Phone Number',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V7','Work Phone Number','Day time Phone Number','File','Payment','Error','V','Invalid Phone Number','You have entered an Invalid Phone number. Please enter a valid phone number.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF10','Fgn Country Name','Foreign Country Name','File','Payment','Error','RF','Missing Foreign Country Name','Select the appropriate Foreign Country code.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF11','Card Type','Card Type','File','Payment','Error','RF','Missing Card Type','Missing Card Type',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF12','Card Number','Credit Card Number','File','Payment','Error','RF','Missing Card Number','Missing Credit card Number',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V8','Card Number','Credit Card Number','File','Payment','Error','V','Invalid Card Number','You have entered an Invalid Card Number. Please enter a valid card number.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF13','CVC','Credit Card CVC','File','Payment','Error','RF','Missing CVC Code value','Missing  CVC code. This card Verification Code is an extra 3 digit  code that is printed on the back of your  debit or credit card',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF14','Expiration Date','Card Expiration Date','File','Payment','Error','RF','Missing  Card Expiration Date','Missing Card Expiration date',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_V9','Expiration Date','Card Expiration Date','File','Payment','Error','V','Invalid Card Expiration date','Card Expiration due date must be greater than current date.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF15','Bank Name','Bank Name','File','Payment','Error','RF','Missing Bank Name','Bank Name is required entry.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF16','Disclaimer','Disclaimer','File','Payment','Error','RF','You have not accepted the information entered regarding the direct debit.','You have not accepted the information entered regarding the direct debit.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF17','Disclaimer','Disclaimer','File','Payment','Error','RF','You have not accepted your responsibility to schedule the tax due payment to the IRS using eftps.gov website.','You have not accepted your responsibility to schedule the tax due payment to the IRS using eftps.gov website.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Payment_RF18','Disclaimer','Disclaimer','File','Payment','Error','RF',' Please accept to the declaration that the tax due payment will be paid by means of check or money order to the United States Treasury.',' Please accept to the declaration that the tax due payment will be paid by means of check or money order to the United States Treasury.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF1','Filed Prior year tax return','Filed Prior year tax return','File','Efile','Error','RF','Select your prior year return Information','Select your prior year return Information',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF2','Email Address','Email Address','File','Efile','Error','RF','Enter Your Email Address','Enter Your Email Address',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF3','E-file Selection','E-file Selection','File','Efile','Error','RF','E-file option not selected for Federal and State','E-file option not selected for Federal and State',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF4','Prior Year  PIN','Prior Year  PIN','File','Efile','Error','RF','Missing Prior year E-filing PIN','Missing  Prior year E-filing PIN( Personal identification Number)',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF5','Self select PIN','Self select PIN','File','Efile','Error','RF','Missing 5 digits E-file PIN','Missing 5 digits E-file PIN(Personal Identification Number)',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF6','Prior year Adjusted Gross Income','Prior year Adjusted Gross Income','File','Efile','Error','RF','Missing Prior Year AGI','Missing prior year Adjusted Gross Income',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF7','Today''s date','Today''s date','File','Efile','Error','RF','Missing Filing date','Missing your return Filing date',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF8','Identity Protection PIN','Identity Protection PIN','File','Efile','Error','RF','Missing Identity Protection PIN','Missing Identity Protection PIN',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_RF9','Verification Code','Verification code','File','Efile','Error','RF','Missing Verification code','Missing Verification Code',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_V1','Verification Code','Verification code','File','Efile','Error','V','Invalid Verification Code','You have entered Invalid Verification code',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_V2','Invalid Email address','invalid Email Address','File','Efile','Error','V','Invalid Email address','Enter a valid email address',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_V3','Invalid Efile PIN','Invalid Efile PIN','File','Efile','Error','V','Invalid Efile PIN','Enter a valid 5 digits  Efile PIN',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_V4','Identity Protection PIN','Identity Protection PIN','File','Efile','Error','V','Invalid Identity Protection PIN','Enter a valid 6 digits Identity Protection PIN',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_V5','Efiling PIN Number','Efiling PIN Number','File','Efile','Error','V','Both Prior year PIN and Self select PIN should not have value.','You have entered PIN number on both Prior year PIN and  2014 Self select PIN. Both the fields should not have value.',NULL,NULL,0)
INSERT INTO [error_message] ([error_code],[field_name],[field_description],[tab],[topic],[error_type],[message_type],[short_error_text],[long_error_text],[message_target],[error_title],[is_deleted])VALUES('Efile_V6','Filing date','Filing Date','File','Efile','Error','V','Your Filing date must be either current date or future date.','Your Filing date must be either current date or future date.',NULL,NULL,0)

GO

/* 14May2014 Ashok Kumar added static data for product*/
INSERT [dbo].[product] ([product_name], [description], [is_active], [is_deleted]) VALUES (N'Form1040EZ', N'Form1040EZ', 1, 0)
INSERT [dbo].[product] ([product_name], [description], [is_active], [is_deleted]) VALUES (N'Form1040A', N'Form1040A', 1, 0)
INSERT [dbo].[product] ([product_name], [description], [is_active], [is_deleted]) VALUES (N'Form1040', N'Form1040', 1, 0)

/* 03Jun2014 Ashok Kumar added static data for product_sku  */
INSERT [dbo].[product_sku] ([product_id], [sku_name], [sku_description], [sku_price], [state_id], [is_active], [is_deleted]) VALUES (1, N'Federal-Form1040EZ', N'Federal Tax Preparation Charge', CAST(0.00 AS Numeric(15, 2)), 0, 1, 0)
INSERT [dbo].[product_sku] ([product_id], [sku_name], [sku_description], [sku_price], [state_id], [is_active], [is_deleted]) VALUES (1, N'State-CA', N'California', CAST(10.00 AS Numeric(15, 2)), 5, 1, 0)
INSERT [dbo].[product_sku] ([product_id], [sku_name], [sku_description], [sku_price], [state_id], [is_active], [is_deleted]) VALUES (1, N'State-NY', N'New York', CAST(10.00 AS Numeric(15, 2)), 33, 1, 0)
INSERT [dbo].[product_sku] ([product_id], [sku_name], [sku_description], [sku_price], [state_id], [is_active], [is_deleted]) VALUES (1, N'State-NJ', N'New Jersey', CAST(10.00 AS Numeric(15, 2)), 31, 1, 0)



/*14Mar2014 SATHISH Added static data for [security_question] table.*/
INSERT INTO [dbo].[security_question](question) VALUES('What was the name of your first school?')
INSERT INTO [dbo].[security_question](question) VALUES('What is your favorite game?')
INSERT INTO [dbo].[security_question](question) VALUES('Which city were you born in?')
INSERT INTO [dbo].[security_question](question) VALUES('What was the name of your first pet?')
INSERT INTO [dbo].[security_question](question) VALUES('Where did you meet your spouse?')
INSERT INTO [dbo].[security_question](question) VALUES('What is the name of your best friend from childhood?')
INSERT INTO [dbo].[security_question](question) VALUES('What was the name of your first boyfriend/girlfriend?')

/* 22May2014 Ashok Kumar added static data for Credit Card Type*/
INSERT [dbo].[credit_card_type] ([credit_card_type], [is_active], [is_deleted]) VALUES (N'Visa', 1, 0)
INSERT [dbo].[credit_card_type] ([credit_card_type], [is_active], [is_deleted]) VALUES (N'Master Card', 1, 0)
INSERT [dbo].[credit_card_type] ([credit_card_type], [is_active], [is_deleted]) VALUES (N'American Express', 1, 0)
INSERT [dbo].[credit_card_type] ([credit_card_type], [is_active], [is_deleted]) VALUES (N'Discover', 1, 0)


/* Sathish added static data for Efile Service*/
INSERT INTO [efile_control]([form_type],[control_name],[control_value]) VALUES('Form1040EZ','ETIN','80293')
INSERT INTO [efile_control]([form_type],[control_name],[control_value]) VALUES('Form1040EZ','ConfirmationToken','mJlo7-N3')
INSERT INTO [efile_control]([form_type],[control_name],[control_value]) VALUES('Form1040EZ','TestIndicator','T')
INSERT INTO [efile_control]([form_type],[control_name],[control_value]) VALUES('Form1040EZ','EFIN','523474')
INSERT INTO [efile_control]([form_type],[control_name],[control_value]) VALUES('Form1040EZ','laURL','https://la.alt.www4.irs.gov/a2a/mef/')

INSERT INTO [irs_systems]([system_id],[password],[salt]) VALUES('52347401',NULL,NULL)
INSERT INTO [irs_systems]([system_id],[password],[salt]) VALUES('52347402',NULL,NULL)
INSERT INTO [irs_systems]([system_id],[password],[salt]) VALUES('52347403',NULL,NULL)


INSERT INTO [efile_irs_users]([form_type],[user_name],[password],[encrypt_key],[decrypt_key]) VALUES('Form1040EZ','52347401','j42OhNZNl99wN/cH1EE53A==','FW9roaFlhQg9Ne3gZ1Za','FW9roaFlhQg9Ne3gZ1Za')
INSERT INTO [efile_irs_users]([form_type],[user_name],[password],[encrypt_key],[decrypt_key]) VALUES('Form1040','52347402','j42OhNZNl99wN/cH1EE53A==','FW9roaFlhQg9Ne3gZ1Za','FW9roaFlhQg9Ne3gZ1Za')
INSERT INTO [efile_irs_users]([form_type],[user_name],[password],[encrypt_key],[decrypt_key]) VALUES('Form1040A','52347403','j42OhNZNl99wN/cH1EE53A==','FW9roaFlhQg9Ne3gZ1Za','FW9roaFlhQg9Ne3gZ1Za')


INSERT INTO [efile_status]([status]) VALUES('Transmitted')
INSERT INTO [efile_status]([status]) VALUES('Approved')
INSERT INTO [efile_status]([status]) VALUES('Accepted')
INSERT INTO [efile_status]([status]) VALUES('Rejected')

INSERT INTO [efile_schema_version]([return_type],[tax_year],[tax_period],[schema_version],[schema_location]) VALUES('Form1040EZ','2014','2014','2014v1.0','E:\AshokCopy\efile1040x_2014v1.0\2014v1.0\IndividualIncomeTax\Ind1040EZ\Return1040EZ.xsd')

INSERT INTO [version]([name],[pdf_name],[is_paper_enabled],[is_efile_enabled],[product_id]) VALUES('41646','f720',1,1,1)

/*Added by Saran 3 July 2014 for Efile Services*/
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Receive Return');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Schema Conversion');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Schema Validation');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Business Validation');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Zip');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Send');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Ping');

--Yogalakshmi - 10th July 2014 - Added static data for error_fix_type table
INSERT [dbo].[error_fix_type] ([error_fix_type]) VALUES (N'Not Fixable')
INSERT [dbo].[error_fix_type] ([error_fix_type]) VALUES (N'Application')
INSERT [dbo].[error_fix_type] ([error_fix_type]) VALUES (N'User')

--Yogalakshmi - 10th July 2014 - Added static data for irs_error_code table
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-001-01', N'If Form 1040EZ, ''SpouseSSN'' has a value in the Return Header, then ''SpouseNameControlTxt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-002-02', N'The age of Primary tax payer on Form 1040EZ must be less than 65. If born January 01, 1949, taxpayer is considered to be age 65 at the end of 2013.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-003-02', N'If Form 1040EZ, ''SpouseSSN'' has a value in the Return Header, then Spouse''s age must be less than 65. If born January 01, 1949, taxpayer is considered to be age 65 at the end of 2013.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-004', N'Form 1040EZ,  Line 2 ''TaxableInterestAmt'' must not be greater than 1500.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-005', N'Form 1040EZ, Line 6 ''TaxableIncomeAmt'' must  be less than 100000.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-006', N'If Form 1040EZ, Line 8a ''EICEligibilityLiteralCd'' has the value ''NO'', then Line 8a ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-008', N'Form 1040EZ, Line 7 ''WithholdingTaxAmt'' must be equal to the sum of the following: (1) all ''WithholdingAmt'' in [OtherWithholdingStatement] attached to Form 1040EZ, Line 7 and (2) all of the Forms W-2, Line 2 ''WithholdingAmt''. When evaluating this a tolerance of $5.00 is allowed.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-009', N'The sum of all Forms W-2, Line 1 ''WagesAmt'' must not be greater than Form 1040EZ, Line 1 ''WagesSalariesAndTipsAmt''. When evaluating this, a tolerance of $5.00 is allowed.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-011', N'If Form 1040-EZ, Line 11a ''RefundAmt'' has a non-zero value, then Line 9 ''TotalPaymentsAmt'' must be greater than Line 10 ''TaxAmt''.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-012', N'If ''PrimarySSN'' in the Return Header is an ITIN, then Line 8a, ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-013', N'If ''SpouseSSN'' in the Return Header is an ITIN, then Line 8a, ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-016-02', N'If Form 1040EZ, Line 5 checkbox ''PrimaryClaimAsDependentInd'' is not checked and ''SpouseSSN'' in the Return Header does not have a value, then Line 5 ''CombStdDedAndPrsnlExemptAmt'' must be equal to 10000.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-017-02', N'If Form 1040EZ, Line 5 checkboxes ''PrimaryClaimAsDependentInd'' and ''SpouseClaimAsDependentInd'' are not checked and ''SpouseSSN'' in the Return Header has a value, then Line 5 ''CombStdDedAndPrsnlExemptAmt'' must be equal to 20000.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-018-02', N'If Form 1040EZ, Line 5 checkboxes ''PrimaryClaimAsDependentInd'' and ''SpouseClaimAsDependentInd'' are checked and ''SpouseSSN'' in the Return Header has a value, then Line 5 ''CombStdDedAndPrsnlExemptAmt'' must not be greater than 12200.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-019-02', N'If Form 1040EZ, Line 5 checkbox ''PrimaryClaimAsDependentInd'' is checked and ''SpouseSSN'' in the Return Header does not have a value, then Line 5 ''CombStdDedAndPrsnlExemptAmt'' must not be greater than 6100.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-020-02', N'Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' must not be greater than 487.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-021-02', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value and ''SpouseSSN'' in the Return Header does not have a value, then Line 4 ''AdjustedGrossIncomeAmt'' must be less than 14340.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-022-02', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value and ''SpouseSSN'' has a value in the Return Header, then Form 1040EZ, Line 4 ''AdjustedGrossIncomeAmt'' must be less than 19680.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-023', N'If Form 1040EZ, Line 5 checkbox ''PrimaryClaimAsDependentInd'' is checked, then Line 8a ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-024', N'If Form 1040EZ, Line 5 checkbox ''SpouseClaimAsDependentInd'' is checked, then Line 8a ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-026', N'If Form 1040-EZ, Line 2 ''TaxableInterestAmt'' has a zero value or has no entry, then Line 4 ''AdjustedGrossIncomeAmt'' must be equal to the sum of Line 1 ''WagesSalariesAndTipsAmt'' and Line 3 ''UnemploymentCompAmt''.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-027', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value, then the Primary Taxpayer and/or the Spouse Taxpayer in the Return Header must be at least 25 years old but not be older than 64.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-028', N'Form 1040EZ, Line 7 ''WithholdingTaxAmt'' must be less than the sum of the following: Line 1 ''WagesSalariesAndTipsAmt'' and Line 2 ''TaxableInterestAmt'' and Line 3 ''UnemploymentCompAmt'' unless  Combat Pay has been excluded from Wages.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-033', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value, then [FECRecord] must not be present in the return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-044', N'Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' must have a zero value if an amount is entered.  e-File database indicates the taxpayer is not allowed to claim Earned Income Credit for this tax year.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-046', N'If the Filer address in the Return Header is a foreign address, then Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-064', N'If Form 1040EZ, Line 8b ''NontxCombatPayElectionAmt'' has a non-zero value, then it must be equal to the sum of all Forms W-2 (for the Primary and/or Spouse), Line 12a ''EmployersUseAmt'' for which ''EmployersUseCd'' is equal to "Q".', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-071-01', N'If ''SpouseSSN'' has a value in the Return Header, then ''SpousePINEnteredByCd'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-073-01', N'If Form 1040EZ, filing status is "Single" (''SpouseSSN'' does not have a value in the Return Header), then ''PrimarySignaturePIN'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-077-01', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' has a value and ''SpouseSignaturePIN'' does not have a value in the Return Header, then ''PrimarySignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-078-01', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' has a value and ''PrimarySignaturePIN'' does not have a value in the Return Header, then ''SpouseSignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-081-01', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingCodeTxt'' has a value and ''SpouseSignaturePIN'' does not have a value in the Return Header, then ''PrimarySignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-082-01', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingCodeTxt'' has a value and ''PrimarySignaturePIN'' does not have a value in the Return Header, then ''SpouseSignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-087-01', N'If Form 1040EZ, ''SpouseSSN'' has a value in the Return Header, then the Filer Name in the Return Header ''NameLine1Txt'' must contain an ampersand(&).', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-396', N'The e-File database indicates a First Time Homebuyer Installment Payment is due for the Primary SSN.  A Form 1040 must be filed, with the repayment amount included on Form 1040, Line 59b or Form 5405 must be attached to Form 1040.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-397', N'The e-File database indicates a First Time Homebuyer Installment Payment is due for the Spouse SSN. A Form 1040 must be filed, with the repayment amount included on Form 1040, Line 59b or Form 5405 must be attached to Form 1040.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-510', N'If Form 1040EZ, Line 5 checkbox ''PrimaryClaimAsDependentInd'' is not checked, then ''PrimarySSN'' in the Return Header must not be equal to a ''DependentSSN'' on another tax return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-511', N'Primary SSN in the Return Header must not be equal to the Spouse SSN on another tax return in which the Filing Status is "Married filing separately".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-513', N'If Form 1040EZ, Line 5 checkbox ''SpouseClaimAsDependentInd'' is not checked, then Spouse SSN in the Return Header must not be the same as a ''DependentSSN'' on another tax return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-524-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and Form 1040EZ, filing status is not "Married filing jointly" (''SpouseSSN'' does not have a value in the Return Header), then ''PrimaryBirthDt'' in the Return Header must match the e-File database.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-003', N'Form 1310, ''DecedentSSN'' must be equal to ''PrimarySSN'' or the ''SpouseSSN'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-005', N'If two Forms 1310 are present in the Return, their ''DecedentSSN''s must not be equal.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-007-01', N'Form 1310, the year of ''DeathDt'' must not be less than ''TaxYr'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-009', N'Form 1310, Part II, Line 2a ''CourtAppointedRepInd'' must have a choice of "No" indicated.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-010', N'Form 1310, Part II, Line 2b ''RepresentativeToBeAppointedInd'' must have a choice of "No" indicated .', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-011', N'Form 1310, Part II, line 3 ''PaymentAccordingToStateLawInd'' must have a choice of "Yes" indicated.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-012', N'Form 1310, ''RefundClaimantSSN'' must not be equal to the ''PrimarySSN'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-013', N'Form 1310, ''RefundClaimantSSN'' must not be equal to the ''SpouseSSN'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-016', N'If two Forms 1310 are present in the Return, their ''RefundClaimantSSN''s must be equal.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-518', N'Form 1310, Name Control of the person claiming refund ''PersonNameControlTxt'' and SSN of Person claiming Refund ''RefundClaimantSSN'' must match the e-File database.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-001', N'There must be at least one checkbox ''InjuredSpouseInd'' checked on Form 8379, Line 10.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-002', N'There must be no more than one checkbox ''InjuredSpouseInd'' checked on Form 8379, Line 10.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-003', N'If Form 8379, Line 5 ''CommunityPropertyStateInd'' has a choice of "Yes" indicated, then Line 5 ''CommunityPropertyStateCd'' must have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-004', N'If Form 8379, Line 13b(a) Joint Return ''TotalOtherIncomeAmt'' must be equal to the sum of Line 13b(b) Injured Spouse ''TotalOtherIncomeAmt'' and Line 13b(c) Other Spouse ''TotalOtherIncomeAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-005', N'If Form 8379, Line 15a Joint Return ''StandardOrItemizedDeductionAmt'' must be equal to the sum of Line 15b Injured Spouse  ''StandardOrItemizedDeductionAmt'' and Line 15c Other Spouse ''StandardOrItemizedDeductionAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-006', N'If Form 8379, Line 16a Joint Return ''AllocatedExemptionCnt'' must be equal to the sum of Line 16b Injured Spouse ''AllocatedExemptionCnt'' and Line 16c Other Spouse ''AllocatedExemptionCnt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-008', N'If Form 8379, Line 17a Joint Return ''CreditAmt'' must be equal to the sum of Line 17b Injured Spouse ''CreditAmt'' and Line 17c Other Spouse ''CreditAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-009', N'If Form 8379, Line 20a Joint Return ''EstimatedTaxPaymentAmt'' must be equal to the sum of Line 20b Injured Spouse ''EstimatedTaxPaymentAmt'' and Line 20c Other Spouse ''EstimatedTaxPaymentAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-011', N'If Form 8379 is present in the return, then Filer must not have a ''ForeignAddress'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-014', N'If Form 8379 is present in the return, then ''SpouseSSN'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-015', N'If Form 8379, Line 13a(a) Joint Return ''WagesAmt'' must be equal to the sum of Line 13a(b) Injured Spouse ''WagesAmt'' and Line 13a(c) Other Spouse ''WagesAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-016', N'If Form 8379, Line 14a Joint Return ''IncomeAdjustmentAmt'' must be equal to the sum of Line 14b Injured Spouse ''IncomeAdjustmentAmt'' and Line 14c Other Spouse ''IncomeAdjustmentAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-017', N'If Form 8379, Line 18a Joint Return ''OtherTaxesAmt'' must be equal to the sum of Line 18b Injured Spouse ''OtherTaxesAmt'' and Line 18c Other Spouse ''OtherTaxesAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-018', N'If Form 8379, Line 19a Joint Return ''FederalIncomeTaxWithheldAmt'' must be equal to the sum of Line 19b Injured Spouse ''FederalIncomeTaxWithheldAmt'' and Line 19c Other Spouse ''FederalIncomeTaxWithheldAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-020', N'If Form 8379 is present in the return, then Form 8833 or Form 8888 must not be present in the return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8862-001-01', N'Form 8862, Line 1 ''EICEligClmFilingYr'' must be equal to ''TaxYr'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-005', N'If Form 8888, Line 5c checkbox ''BeneficiaryInd'' is checked, then Line 5c ''BondCoOwnerOrBeneficiaryNm'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-007-01', N'Form 8888, Line 8 ''TotalAllocationOfRefundAmt'' must be equal to Form 1040EZ, Line 11a ''RefundAmt''.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-009', N'If Form 8888, Line 4 ''RefundUsedForBondPurchasesAmt'' has a non-zero value, then it must be a multiple of 50 and must not be greater than 5000.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-001-02', N'Form 9465, Line 9 ''TotalTaxDueAmt'' must not be greater than 50000.  If the tax due amount is greater than 50000, complete and mail Form 9465 with Form 433-F to the mailing address provided on www.irs.gov.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-014', N'Form 9465, Line 1 ''PrimarySSN'' must be equal to either the ''PrimarySSN'' or ''SpouseSSN'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-015', N'If Form 9465, Line 1 ''SpouseSSN'' has a value, then it must be equal to either the ''PrimarySSN'' or ''SpouseSSN'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-016-01', N'If Form 9465, Line 13a ''RoutingTransitNum'' has a value, then Line 13b ''BankAccountNum'' must also have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-017-01', N'If Form 9465, Line 13b ''BankAccountNum'' has a value, then Line 13a ''RoutingTransitNum'' must also have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-018-01', N'In Form 9465, one of the following must have a value: Line 3 Home ''PhoneNum'' or Line 4 Work ''PhoneNum'' or Line 3 Home ''ForeignPhoneNum'' or Line 4 Work ''ForeignPhoneNum''.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-019-01', N'If IRS Payment Record is present in the return, then Form 9465, Line 8 ''PaymentAmt'' must be equal to ''PaymentAmt'' in IRS Payment Record.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-020-01', N'If Form 9465, Line 1a ''SpouseName'' has a value, then ''SpouseNameControlTxt'' must also have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-026', N'Form 9465, Line 14 checkbox ''PayrollDeductionAgreementInd'' must not be checked.  If the Payroll Deduction Agreement box is checked, complete and mail Form 9465 with Form 2159 to the mailing address provided on www.irs.gov.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-027', N'Form 9465, Line 10 ''PaymentDueAmt'' can not be less than Line 11 ''CalculatedMonthlyPymtAmt''.  If the payment due amount is less than Line 11, calculated monthly payment amount, complete and mail Form 9465 with Form 433-F to the mailing address provided on www.irs.gov.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-029', N'If Form 9465 is attached to Form 1040 or Form 1040A or Form 1040EZ or Form 1040PR or Form 1040SS, then ''F9465TaxReturnTypeCd'' must not have the following values: "FORM 940" or "FORM 940PR" or "FORM 941" or "FORM 941PR" or "FORM 941SS" or "FORM 943" or "FORM 943PR" or "FORM 944" or "FORM 945" or "FORM 720" or "FORM 2290".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F9465-030', N'If Form 9465 ''F9465TaxReturnTypeCd'' has a value of "FORM 1040" or "FORM 1040A" or "FORM 1040EZ" or "FORM 1040SS" or "FORM 1040PR", then ''IATaxYrDt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-043-04', N'If the processing date is after June 21, 2014, but prior to September 21, 2014, then the ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be September 15, 2014 or January 15, 2015.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-044-04', N'If the processing date is after September 20, 2014, but prior to January 1, 2015, then the ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be January 15, 2015.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-045-02', N'''EstimatedPaymentDueDt'' in the IRS ES Payment Record must not be the same as another IRS ES Payment Record filed with the same return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-046-04', N'If the processing date is after December 31, 2013, but prior to January 16, 2014, then the ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be April 15, 2014 or June 16, 2014 or September 15, 2014.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-047-04', N'If the processing date is after April 20, 2014, but prior to June 22, 2014, then the ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be June 16, 2014 or September 15, 2014 or January 15, 2015.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-056-03', N'If the processing date is after January 15, 2014, but prior to April 21, 2014, then ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be April 15, 2014 or June 16, 2014 or September 15, 2014 or January 15, 2015.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-068-01', N'''PaymentAmt'' in the IRS Payment Record must not be greater than 99,999,999.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-069-01', N'''PaymentAmt'' in the IRS ES Payment Record must not be greater than 99,999,999.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-071-01', N'''RequestedPaymentDt'' in the IRS Payment Record must not be more than 5 days prior to the received date.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-072-01', N'If the return is received on or before the due date of the return, then the ''RequestedPaymentDt'' in the IRS Payment Record must be on the due date or before the due date.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-074-01', N'If the return is received after the due date of the return, then the ''RequestedPaymentDt'' in the IRS Payment Record must not be later than the date the return was received.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-086', N'''EstimatedPaymentDueDt'' in the IRS ES Payment Record must not be more than 5 days prior to the received date.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-087', N'''EstimatedPaymentDueDt'' in the IRS ES Payment Record must not be more than one year after the received date.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FW2-002', N'Form W-2, Line 1 ''WagesAmt'' must have a value greater than zero unless Combat Pay has been excluded from income.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FW2-003-01', N'Form W-2, Line a, ''EmployeeSSN'' must be equal to ''PrimarySSN'' or ''SpouseSSN'' in the Return Header.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FW2-499', N'Form W-2, Line B ''EmployerEIN'' is invalid for processing an Individual e-filed return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FW2-502', N'Form W-2, Line B ''EmployerEIN'' must match data in the eFile database.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FW2-505-01', N'Form W-2, Line B ''EmployerEIN'' was issued after the Tax Year in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-001-01', N'''PreparerSSN'' in the Return Header must not be all zeros or all nines.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-002', N'The ''TaxPeriodEndDate''  in the Submission Manifest must be less than the "Received Date".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-005-01', N'If Form 9465 and IRS Payment Record are present in the return, then Form 9465, ''PaymentAmt'' must be equal to ''PaymentAmt'' in IRS Payment Record.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-006', N'''SpouseSSN'' in the Return Header must not be equal to ''PrimarySSN'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-007-01', N'If checkbox ''ProtectiveSec108iELCRecordInd'' is checked in the return, then [GeneralDependencyMedium] with Description beginning with ''Section 108(i) election explanation'' must be attached to the return.', NULL, N'Missing Document', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-010', N'''TaxYear'' must equal the year of the ''TaxPeriodBeginDate'' ("YYYY" digits) in the Submission Manifest.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-011', N'''TaxYear'' must equal the year of the ''TaxPeriodEndDate'' ("YYYY" digits) in the Submission Manifest.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-013-01', N'In the Return Header, ''PreparerSSN'' or ''PTIN'' or ''STIN'' or ''PreparerFirmEIN'' must have a value, if any one of the following is true: (1) checkbox ''SelfEmployedInd'' is checked; (2) ''PreparerPersonNm'' or ''PreparerFirmName'' or ''PreparerUSAddress'' or ''PreparerForeignAddress'' has a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-015', N'If checkbox ''WorkPerformedResidingInUSInd'' is checked in [FECRecord], then ''USAddress'' must have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-016', N'If ''USAddress'' has a value in [FECRecord], then checkbox ''WorkPerformedResidingInUSInd'' must be checked.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-020-01', N'If ''PaidPreparerInformationGrp'' is present in the Return Header, then ''NonPaidPreparerCd'' must not have a value in the return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-021-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and ''PrimarySignaturePIN'' has a value, then ''PrimaryBirthDt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-022-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and ''SpouseSignaturePIN'' has a value, then ''SpouseBirthDt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-023-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner" and ''PrimarySignaturePIN'' has a value, then ''PrimaryBirthDt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-024-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner" and ''SpouseSignaturePIN'' has a value, then ''SpouseBirthDt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-025-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line", and ''PrimaryBirthDt'' has a value, then ''PrimaryPriorYearAGIAmt'' or ''PrimaryPriorYearPIN'' or ''PrimaryElectronicFilingPIN'' or ''IdentityProtectionPIN'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-026-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner", and ''PrimaryBirthDt'' has a value, then ''PrimaryPriorYearAGIAmt'' or ''PrimaryPriorYearPIN'' or ''PrimaryElectronicFilingPIN'' or ''IdentityProtectionPIN'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-027-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line", and ''SpouseBirthDt'' has a value, then ''SpousePriorYearAGIAmt'' or ''SpousePriorYearPIN'' or ''SpouseElectronicFilingPIN'' or ''SpouseIdentityProtectionPIN'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-028-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner", and ''SpouseBirthDt'' has a value, then ''SpousePriorYearAGIAmt'' or ''SpousePriorYearPIN'' or ''SpouseElectronicFilingPIN'' or ''SpouseIdentityProtectionPIN'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-031-01', N'''PrimaryPriorYearPIN'' or ''PrimaryElectronicFilingPIN'' or ''PrimaryPriorYearAGIAmt'' in the Return Header must match the e-File database.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-032-01', N'''SpousePriorYearPIN'' or ''SpouseElectronicFilingPIN'' or ''SpousePriorYearAGIAmt'' in the Return Header must match the e-File database.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-041', N'If ''ThirdPartyDesigneeInd'' in the return has a choice of ''Yes'' indicated, then ''ThirdPartyDesigneePIN'' must have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-046', N'Form 8862 must be present in the return.  e-File database indicates the taxpayer must file Form 8862 to Claim Earned Income Credit after disallowance.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-052', N'The TIN present in the IRS Submission Manifest must be equal to the Primary SSN in the Return Header.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-056-01', N'If ''PrimarySignaturePIN'' has a value in the Return Header, then ''PrimaryPINEnteredByCd'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-057-01', N'If ''SpouseSignaturePIN'' has a value in the Return Header, then ''SpousePINEnteredByCd'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-058-01', N'If ''PrimarySignaturePIN'' has a value in the Return Header, then ''PrimarySignatureDt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-059-01', N'If ''SpouseSignaturePIN'' has a value in the Return Header, then ''SpouseSignatureDt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-060', N'''IdentityProtectionPIN'' in the Return Header must not equal all zeroes.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-061', N'IRS ES Payment Record must not be present in a prior year return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-062', N'IP Address of the Transmitter must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-063', N'Timestamp of the Transmitter must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-064', N'IP Address of the Transmitter must be a valid IP Address.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-066', N'''SpouseIdentityProtectionPIN'' in the Return Header must not equal all zeroes.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-067', N'As a paid tax preparer of a tax return claiming Earned income Tax Credit, you must complete and submit Form 8867 to IRS with the original submission of each return. Failure to submit Form 8867 is a violation of IRC Sec 6695(g) and a $500 penalty may be imposed per return.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-180', N'Primary taxpayer''s Identity Protection Personal Identification Number (IP PIN) must match the e-File database.  Please double check your entry and resubmit your return with the correct number.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-181', N'The Primary Taxpayer did not enter a valid Identity Protection Personal Identification Number (IP PIN).  Please  visit www.irs.gov/get-an-ippin for further information and resubmit your return with the correct number.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-182', N'The Spouse Identity Protection Personal Identification Number (IP PIN) must match the e-File database. Please double check your entry and resubmit your return with the correct number.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-183', N'The Spouse did not enter a valid Identity Protection Personal Identification Number (IP PIN).  Please  visit www.irs.gov/get-an-ippin for further information and resubmit your return with the correct number.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-508', N'Primary SSN in the Return Header must not be equal to the Spouse SSN on another tax return  for which filing status is Married Filing Jointly or  [filing status is Married Filing Separately and the Spouse exemption is claimed].', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-510', N'Spouse SSN in the Return Header must not be equal to the Primary SSN on another tax return.', NULL, N'Duplicate Condition', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-513', N'The Spouse SSN in the Return Header must not be equal to the Spouse SSN in another return filed for the same tax year.', NULL, N'Duplicate Condition', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-515', N'The Primary SSN in the Return Header must not be equal to the Primary SSN in another return filed for the same tax year.', NULL, N'Duplicate Condition', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-521-01', N'The Year of Birth of the Primary SSN must not be greater than the ''TaxYr'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-531-01', N'If Primary Date of Death has a value in the e-File database, then it must not be prior to the ''TaxYr'' in the Return Header.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-532-01', N'If Spouse Date of Death has a value in the e-File database, then it must not be prior to the ''TaxYr'' in the Return Header.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-570-01', N'The Year of Birth of the Spouse SSN must not be greater than the ''TaxYr'' in the Return Header.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-664-01', N'If the Primary SSN appears more than once in the e-File database, then ''PINTypeCd'' in the Return Header must not have the value "Self-Select On-Line".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-665-01', N'If the Primary SSN appears more than once in the e-File database, then ''PINTypeCd'' in the Return Header must not have the value "Self-Select Practitioner".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-666-01', N'If the Spouse SSN appears more than once in the e-File database, then ''PINTypeCd'' must not have the value "Self-Select On-Line".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-667-01', N'If the Spouse SSN appears more than once in the e-File database, then ''PINTypeCd'' must not have the value "Self-Select Practitioner".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-672-01', N'In the Return Header, if ''PINTypeCd'' has the value "Practitioner" or "Self-Select Practitioner", then ''PractitionerPINGrp'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-673-01', N'In the Return Header, if ''PINTypeCd'' has the value "Self-Select On-Line", then ''PractitionerPINGrp'' must not have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-674-01', N'If the Primary Taxpayer  is under the age of 16 and has never filed a tax return, then ''PINTypeCd'' in the Return Header must not have the value "Self-Select On-Line".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-675-01', N'If the Primary Taxpayer  is under the age of 16 and has never filed a tax return, then ''PINTypeCd'' in the Return Header must not have the value "Self-Select Practitioner".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-679-01', N'If the Spouse SSN in the Return Header is under the age of 16 and did not file a tax return in the previous year, then the ''PINTypeCd'' must not have the value "Self-Select On-Line".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-680-01', N'If the Spouse SSN in the Return Header is under the age of 16 and did not file a tax return in the previous year, then the ''PINTypeCd'' must not have the value "Self-Select Practitioner".', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-689-01', N'The year of the ''PrimarySignatureDt'' in the Return Header must be equal to the processing year.', NULL, N'Missing Document', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-694-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner", then ''JuratDisclosureCd'' must have the value "Self Select PIN By ERO".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-695-01', N'If ''PINTypeCd'' in the Return Header has the value "Practitioner", then ''JuratDisclosureCd'' must have the value "Practitioner PIN".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-696-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line", then ''JuratDisclosureCd'' must have the value "Online Self Select PIN".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-699-01', N'If ''PINTypeCd'' in the Return Header has the value "Practitioner", then the following must not have an entry: ''PrimaryPriorYearAGIAmt'' and ''PrimaryPriorYearPIN'' and ''PrimaryElectronicFilingPIN'' and ''SpousePriorYearAGIAmt'' and ''SpousePriorYearPIN'' and ''SpouseElectronicFilingPIN''.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-769', N'''IdentityProtectionPIN'' in the Return Header must be numeric digits.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-770', N'''SpouseIdentityProtectionPIN'' in the Return Header must be numeric digits.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-901', N'The Primary SSN in the Return Header has been locked because Social Security Administration records indicate the number belongs to a deceased individual.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-902', N'The Primary SSN in the Return Header has been locked.  The account was locked per the taxpayer''s request.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-904', N'The Primary SSN in the Return Header has been locked.  Social Security Administration records indicate the SSN belongs to a minor.  The account was locked per the request of the minor''s parent or guardian.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-941', N'The Spouse SSN in the Return Header has been locked because Social Security Administration records indicate the number belongs to a deceased individual.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-942', N'The Spouse SSN in the Return Header has been locked.  The account was locked per the taxpayer''s request.   ', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-943', N'The Spouse SSN in the Return Header has been systemically locked based on IRS information which indicates there is not a filing requirement for this SSN.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-944', N'The Spouse SSN in the Return Header has been locked.  Social Security Administration records indicate the SSN belongs to a minor.  The account was locked per the request of the minor''s parent or guardian.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-003', N'The return version (attribute ''returnVersion'' of the Return element) must be specified for each return in the return header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-004-01', N'''ReturnTypeCd'' (specified in the Return Header) and the return version (specified by the ''returnVersion'' attribute of the ''Return'' element) of the return must match the return type and the version supported by the Modernized e-File system.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-019', N'The number of return documents (forms, schedules, and supporting documents) included in the return must equal the document count specified in the Return Data (documentCount attribute of the ReturnData element of the Return).', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-030-01', N'In the Return Header, if ''PractitionerPINGrp'' is provided, then ''EFIN'' in the ''PractitionerPINGrp'' must be the same as ''EFIN'' in the ''OriginatorGrp''.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-051-01', N'''FederalSubmissionType'' in the IRS Submission Manifest must match ''ReturnTypeCd'' indicated in the Return Header.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-052-01', N'''TaxYear'' specified in the IRS Submission Manifest must match ''TaxYr'' in the Return Header.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-054-01', N'The ''EFIN'' in the IRS Submission Manifest must match ''EFIN'' in the ''OriginatorGrp'' in the Return Header.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-057', N'Every attached file (i.e. binary attachment) must be referenced by the XML document that represents it.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-058', N'An XML document that represents a binary attachment must have a valid reference to an attached file.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-060', N'The EFIN in the Submission ID (the first six digits) must match the EFIN in the Submission Manifest.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-067', N'The attached files (i.e. binary attachments) in a submission zip archive must have distinct names.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-080-01', N'''TaxPeriodBeginDate'' present in the IRS Submission Manifest must match ''TaxPeriodBeginDt'' provided in the Return Header.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-081-01', N'The TaxPeriodEndDate present in the IRS Submission Manifest must match ''TaxPeriodEndDt'' provided in the Return Header.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-082', N'The TaxPeriodBeginDate and TaxPeriodEndDate must be provided in the IRS Submission Manifest.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-087-02', N'''PreparerFirmEIN'' in the Return Header must not equal all zeros or all nines.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-088-01', N'The eight numeric digits of the PTIN (of the Paid Preparer) following the letter P, must not equal all zeros or all nines in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-092-01', N'''PrimarySSN'' in the Return Header must be within the valid range of SSN/ITIN and must not be an ATIN.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-093-01', N'If ''SpouseSSN'' in the Return Header has a value, then it must be within the valid range of SSN/ITIN and must not be an ATIN.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-095-02', N'''PrimarySignaturePIN'' in the Return Header must not equal all zeros.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-096-02', N'''SpouseSignaturePIN'' in the Return Header must not equal all zeros.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-113-01', N'The eight numeric digits of the STIN (of the Paid Preparer) following the letter S, must not equal all zeros or all nines in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-114', N'The Submission Manifest''s ''TaxPeriodBeginDate'' value for month and day should be January 1.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-115', N'The Submission Manifest''s ''TaxPeriodEndDate'' value for month and day should be December 31.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-118-01', N'If first two digits of the EFIN in the IRS Submission Manifest are 10, 21, 32, 44 or 53, then ''OriginatorTypeCd'' in the Return Header must have the value "OnlineFiler".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-119-01', N'If ''OriginatorTypeCd'' in the Return Header has the value "OnlineFiler", then the first two digits of the EFIN in the IRS Submission Manifest must be 10 or 21 or 32 or 44 or 53.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-120', N'The IRS Submission type that was filed is not being accepted by Modernized e-File (MeF) at this time.  Please check the MeF web page under irs.gov for more information.  The submission type filed was <type>.', NULL, N'Unsupported', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-121', N'The ETIN associated with the Individual submission is not a participating transmitter.  Please check the Modernized e-File (MeF) web page under irs.gov for more information on participation rules.', NULL, N'Unsupported', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-123-01', N'If ''NameLine1Txt'' in the Return Header contains an ampersand, then ''SpouseSSN'' in the Return Header must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-125-01', N'''NameLine1Txt'' in the Return Header must contain a less-than sign (<).', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-126-01', N'There can be no more than two less-than signs (<) in ''NameLine1Txt'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-127-01', N'The character following the first less-than sign in ''NameLine1Txt'' in the Return Header must be an alphabetic character.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-129-01', N'The 4th and 5th digits of the ''PrimarySSN'' in the Return Header must be equal to "00" for testing.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-130-01', N'The 4th and 5th digits of the ''SpouseSSN'' in the Return Header must be equal to "00" for testing.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-142-01', N'If you are a paid tax return preparer, you must use a Preparer Tax Identification Number (PTIN) issued by the Internal Revenue Service (IRS) to identify yourself in the paid preparer section of the tax return.  In future years, tax returns may be rejected if an SSN, or any number that is not a valid PTIN, is included in this field.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-143', N'Tax Year in the IRS Submission Manifest must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-180', N'''TaxYear'' specified in the Submission Manifest must equal the year of the schema version (''YYYY'' digits of the attribute ''returnVersion'' of the Return) that is being used to file the return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-192', N'Phone Number provided in the return must not be all zeros.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-193', N'Bank Account Number provided in the return must not be all zeros.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-194', N'Return must not be a duplicate of a previously accepted return.', NULL, N'Duplicate Condition', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-500-01', N'''PrimarySSN'' and ''PrimaryNameControlTxt'' in the Return Header must match the e-File database.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-902-01', N'Taxpayer TIN in the Return Header must not be the same as a TIN of a previously accepted electronic return for the return type and tax period indicated in the tax return.', NULL, N'Duplicate Condition', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-904-03', N'Software ID in the Return Header must have passed testing for the form family and ''TaxYr''.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-905-01', N'Electronic Filing Identification Number (EFIN) in the Return Header must be listed in the e-File database and in accepted status.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-001', N'The agency to which a State Submission is filed must participate in the Fed/State program.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-005', N'The Submission Category of  a State Submission  must match Submission Category of the referenced IRS Submission.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-006', N'If IRS Submission ID is not provided in the State Submission Manifest, the State must participate in the State Stand Alone Program.', NULL, N'Unsupported', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-007', N'The IRS Submission ID referenced in the State Submision must be that of an IRS Return.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-010', N'The Tax Year referenced in the State Submission Manifest must match the Tax Year of the linked Federal return.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-011', N'An SSN (either the Primary or the Spouse) referenced in the State Submission Manifest must match an SSN (either the Primary or the Spouse) of a linked Federal return.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-012', N'The State Submission category that was filed is not being accepted by Modernized e-File (MeF) at this time.  Please check the MeF web page under irs.gov for more information.  The submission category filed was <category>.', NULL, N'Unsupported', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-013', N'The ETIN associated with the Individual submission is not a participating transmitter.  Please check the Modernized e-File (MeF) web page under irs.gov for more information on participation rules.', NULL, N'Unsupported', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-015', N'If the Submission Category in the State Submission Manifest has a value of ("CORP" or "PART" or "IND" or "EO" or "ESTRST"), then ''TaxYear''  in the State Submission Manifest must be be valid for the current or prior year returns that are being accepted by Modernized e-File (MeF).', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-016', N'If the Submission Category in the State Submission Manifest has a value of ("CORPEP" or "PARTEP" or "INDEP"or "ESTRSTEP"), then ''TaxYear''  in the State Submission Manifest must be the same as processing year.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-017', N'If the Submission Category in the State Submission Manifest has a value of ("CORPEP" or "PARTEP" or "INDEP"or "ESTRSTEP"), then ''IRSSubmissionId'' in the State Submission Manifest must not have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-019', N'In the State Submission Manifest, if the Submission Category has a value of ("IND" or "INDEP"), then ( ''PrimarySSN''  and ''PrimaryNameControl'' ) or ''TempID'' must have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-901', N'The IRS Submission ID referenced in the State Submission Manifest must be present in the e-File database.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-902', N'The IRS Submission ID referenced in the State Submission Manifest must be in accepted status.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'STATE-903', N'Electronic Filing Identification Number (EFIN) in the State Submission Manifest must be approved and present in the e-File database.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'T0000-013', N'The Message ID must be globally unique.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'T0000-014', N'The Submission ID must be globally unique.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'T0000-015', N'The ETIN in the Message ID (the first five digits) must match the ETIN provided with the request.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'T0000-016', N'The Message ID must be 20 positions in length and conform to the following format: 12 digits followed by 8 alphanumeric characters (only lower case alphabetic characters allowed).', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'T0000-017', N'The Submission ID must be 20 characters in length.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'T0000-900', N'Transmission cannot be a duplicate of a previously accepted transmission.', NULL, N'Duplicate Condition', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-005', N'The XML data has failed schema validation.', NULL, N'XML Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-008', N'The namespace declarations in the root element of the return (''Return'' element) must be as follows:The default namespace shall be set to  "http://www.irs.gov/efile" (xmlns= "http://www.irs.gov/efile").The namespace prefix "efile" shall be bound to the namespace  "http://www.irs.gov" (xmlns:efile="http://www.irs.gov/efile").', NULL, N'XML Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-009', N'The SOAP envelope structure in the Transmission file must conform to the SOAP 1.1 specification.', NULL, N'XML Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-010', N'For each SubmissionID provided in the transmission manifest there must be a submission zip archive entry present in the Attachment Zip file whose name (without the ".zip" extension) matches the SubmissionID.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-011', N'All entries in the submission zip archive (zip file that is the submission) must begin with "manifest/" or "/manifest/" or "xml/" or "/xml/" or "attachment/" or  "/attachment/" (all lower case characters).', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-012', N'The name of a binary attachment file must be less than or equal to 64 bytes.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-015', N'Each zip entry in the Attachment Zip file must end with ".zip" extension.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-017', N'ZIP Entry names in the transmission ZIP archive must be unique.', NULL, N'Duplicate Condition', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-018', N'A submission zip archive (zip file that is the submission) must contain exactly one entry that begins with  "manifest/" or "/manifest/" and is followed by the file name "manifest.xml".  The entry name must use lower case characters (''a'' through ''z'') only and the separator must be the forward slash character.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-019', N'A submission zip archive (zip file that is the submission) must contain exactly one entry that consists of "xml/" or "/xml/" (all lower case characters) followed by a file name.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-020', N'A submission zip archive (zip file that is the submission) may contain zero or more entries that begin with "attachment/" or "/attachment/" and each is followed by a file name.  The entry name must use lower case characters (''a'' through ''z'') only and the separator must be the forward slash character.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-021', N'The submission zip archive entries (zip files) in the container zip file must be in the root directory of the container zip file.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-022', N'The names of ZIP Entries (files) within the attachments zip file (the container zip file that contains zip files for all submission) must be unique.', NULL, N'Duplicate Condition', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-024', N'Unable to read a binary attachment in the Submission Zip Archive.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-025', N'Unable to read XML data from the Submission Zip Archive.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-026', N'The count of SubmissionIDs provided in the transmission manifest must match the count of submission zip archive entries in the Attachment Zip file.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-027', N'Year (YYYY) in the SubmissionID must be processing year.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-028', N'A single PDF file must not exceed 60MB in size.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-029', N'A binary attachment submitted in the PDF format must begin with the file header "%PDF-".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-030', N'The size and CRC32 checksum value must be provided for the submission XML file (i.e. xml data file that starts with "xml/" or "/xml/").', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-031', N'Zip Entry names must consist of ASCII characters only.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-032', N'Unable to extract submission Zip Archive from the Message Attachment zip file.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'X0000-033', N'Modernized e-File (MeF) accepts submissions only in the Unicode Transformation Format-8 (UTF-8) format.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-007-01', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value, then [ in [WagesNotShownSchedule] attached to Line 1, at least one ''WagesLiteralCd'' must have the value "HSH" and the corresponding  ''WagesNotShownAmt'' must be greater than zero ] or Form W-2 must be present in the return.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-010-01', N'If any of the following Form 1040-EZ fields have a value, then all of these fields must have a value: Line 11b ''RoutingTransitNum'' and Line 11c  ''BankAccountTypeCd'' and Line 11d ''DepositorAccountNum''.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-025-01', N'At least one of the following lines on Form 1040EZ must have a non-zero value: Line 4 ''AdjustedGrossIncomeAmt'' or Line 9 ''TotalPaymentsAmt'' or Line 10 ''TaxAmt'' or Line 11a ''RefundAmt'' or Line 12 ''OwedAmt''.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-029-01', N'If Form 1040EZ, Line 12 ''OwedAmt'' has a non-zero value, then Line 10 ''TaxAmt'' must be greater than Line 9 ''TotalPaymentsAmt''.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-034-01', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value, then ''WagesLiteralCd'' in [WagesNotShownSchedule] must not have the value "FEC".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-049-01', N'If ''SpouseSSN'' is has a value in the Return Header,  and on Form 1040EZ, [both ''PrimaryDeathDt'' and ''SpouseDeathDt'' has a value] and Line 11a ''RefundAmt'' has a non-zero value, then two Forms 1310 must be present in the return.', NULL, N'Missing Document', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-050-01', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value, then Form 1040EZ, ''SurvivingSpouseInd'' must be checked.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-051-01', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''SpouseDeathDt'' has a value, then Form 1040EZ, ''SurvivingSpouseInd'' must be checked.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-052-01', N'If ''SpouseSSN'' does not have a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value and Line 11a ''RefundAmt'' has a non-zero value, then no more than one Form 1310 must be present in the return.', NULL, N'Multiple Documents', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-054-01', N'If ''SpouseSSN'' does not have a value in the Return Header, and on Form 1040EZ, both  ''PrimaryDeathDt'' and ''SpouseDeathDt'' has a value, then Form 1040EZ ''PersonalRepresentativeInd'' must be checked.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-061-02', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value, then the Filer name in the Return Header ''NameLine1Txt'' must contain either " DECD" or "<DECD".', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-062-02', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value, then the Filer name in the Return Header ''NameLine1Txt'' must contain "DECD &".', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-063-02', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''SpouseDeathDt'' has a value, then the Filer name in the Return Header ''NameLine1Txt'' must contain " DECD".', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-065-01', N'Form 8888 must not be present in the return if any one of the following lines of Form 1040EZ has a value: Line 11b ''RoutingTransitNum'' or Line 11c ''BankAccountTypeCd'' or Line 11d ''DepositorAccountNum''.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-074-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''PrimaryDeathDt'' does not have a value, then ''PrimarySignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-075-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''SpouseDeathDt'' does not have a value, then ''SpouseSignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-076-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''PrimaryDeathDt'' has a value and ''SpouseDeathDt'' has a value, then ''PrimarySignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-079-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''CombatZoneCd'' has a value and ''SpouseSignaturePIN'' does not have a value in the Return Header, then ''PrimarySignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-080-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''CombatZoneCd'' has a value and ''PrimarySignaturePIN'' does not have a value in the Return Header, then ''SpouseSignaturePIN'' must have a value in the Return Header.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-088-01', N'If Form 1040EZ, ''SpouseSSN'' has a value in the Return Header and both ''PrimaryDeathDt'' and ''SpouseDeathDt'' have a value, then checkbox ''PersonalRepresentativeInd'' must be checked.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-336-01', N'If ''SpouseSSN'' does not have a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value and Line 11a ''RefundAmt'' has a non-zero value, then Form 1310 must be attached to Form 1040EZ.', NULL, N'Missing Document', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-402-01', N'If [FEC Record] is present in the return, then in [WagesNotShownSchedule], there must be at least one ''WagesLiteralCd'' that has the value "FEC".', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-411-01', N'If Form 1040EZ, Line 12 ''OwedAmt'' has a value greater than zero, then Line 11a ''RefundAmt'' must be equal to zero if an amount is entered.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-412-01', N'If Form 1040EZ, Line 11a ''RefundAmt'' has a value greater than zero, then Line 12 ''OwedAmt'' must be equal to zero if an amount is entered.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-525-02', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''PrimaryDeathDt'' does not have a value, then ''PrimaryBirthDt'' in the Return Header must match the e-File database.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1040EZ-526-02', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''SpouseDeathDt'' does not have a value, then ''SpouseBirthDt'' in the Return Header must match the e-File database.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-006-02', N'Form 1310, ''RefundDueTaxYr'' must be equal to ''TaxYr'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F1310-008-01', N'Form 1310, ''DeathDt'' must be the same as ''PrimaryDeathDt''  or ''SpouseDeathDt'' in the return.', NULL, N'Data Mismatch', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8379-012-01', N'If Form 8379 is present in the return, then the ''StateAbbreviationCd'' of Filer address in the Return Header must not have the value "PR" or "VI".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8862-002-01', N'For each Form 8862, Line 4, ''EICEligClmDaysChldLivedInUSCnt'' that has a value less than 183 days, the corresponding Line 5  ''EICEligClmChildBirthMonthDayDt'' or Line 5 ''EICEligChildDeathMonthDayDt'' must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8862-003-01', N'If Form 8862, Line 7 ''EICEligClmLivedWithOthersInd'' has a choice of "Yes" indicated, then there must be at least one ''EICEligClmOtherPersonNm''  and ''EICEligClmOtherPersonRlnDesc'' with a value among Line 7a, 7b and 7c.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-001-03', N'The sum of all amounts on Form 8888, Line 1a ''DirectDepositRefundAmt'' and Line 4 ''RefundUsedForBondPurchasesAmt'' and Line 5a ''BondPurchaseAmt'' and Line 7 ''RefundByCheckAmt'' must be equal to Line 8 ''TotalAllocationOfRefundAmt''.', NULL, N'Math Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-010-01', N'If Form 8888, Line 4 ''RefundUsedForBondPurchasesAmt'' has a non-zero value, then (Form 1040 or Form 1040A or Form 1040EZ or Form 1040-SS or Form 1040-PR) ''PrimaryDeathDt'' must not have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-011-01', N'If Form 8888, Line 4 ''RefundUsedForBondPurchasesAmt'' has a non-zero value, then (Form 1040 or Form 1040A or Form 1040EZ or Form 1040-SS or Form 1040-PR) ''SpouseDeathDt'' must not have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-012-01', N'For each Bond Purchase information on Form 8888, if Line 5a ''BondPurchaseAmt'' has a value, then it must be a multiple of 50 and must not be greater than 5000.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-013-01', N'For each Bond Purchase information on Form 8888, if Line 5a ''BondPurchaseAmt'' has a value, then (Form 1040 or Form 1040A or Form 1040EZ or Form 1040-SS or Form 1040-PR) ''PrimaryDeathDt'' must not have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8888-014-01', N'For each Bond Purchase information on Form 8888, if Line 5a ''BondPurchaseAmt'' has a value, then (Form 1040 or Form 1040A or Form 1040EZ or Form 1040-SS or Form 1040-PR) ''SpouseDeathDt'' must not have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8965-001', N'If Form 8965, Part III, Line d checkbox ''AllYearInd'' is not checked, then at least one of the following checkboxes in ''MonthIndicatorGrp'' must be checked: Line e ''JanuaryInd'' or Line f ''FebruaryInd'' or Line g ''MarchInd'' or Line h ''AprilInd'' or Line i ''MayInd'' or Line j ''JuneInd'' or Line k ''JulyInd'' or Line l ''AugustInd'' or Line m ''SeptemberInd'' or Line n ''OctoberInd'' or Line o ''NovemberInd'' or Line p ''DecemberInd''.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'F8965-004', N'Form 8965, ''SSN'' must be equal to ''PrimarySSN'' or ''SpouseSSN'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FPYMT-064-02', N'''PaymentAmt'' in the IRS Payment Record must not be more than 200% of the Form 1040EZ, Line 12 ''OwedAmt'' amount. If a value is not provided on Form 1040EZ, Line 12, treat that value as zero.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FW2-007-01', N'''CityNm'' of Form W-2, Line C ''EmployerUSAddress'' must contain at least three characters.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'FW2-008-01', N'''CityNm'' of Form W-2, Line C ''EmployerForeignAddress'' must contain at least three characters.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-012-01', N'If ''WagesLiteralCd'' in [WagesNotShownSchedule] has the value  "FEC", then [FECRecord] must be present in the return.', NULL, N'Missing Document', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-014-02', N'''EmployeeTIN'' and ''EmployeeNameControlTxt'' in [FECRecord] must be the same as [ ''PrimarySSN'' and ''PrimaryNameControlTxt'' ] or [''SpouseSSN'' and ''SpouseNameControlTxt'' ] in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-018-02', N'If ''PrimaryDeathDt'' has a value in the return, then ''InCareOfNm'' in the Filer address in the Return Header must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-019-02', N'If ''SpouseDeathDt'' has a value in the return, then ''InCareOfNm'' in the Filer address in the Return Header must have a value.', NULL, N'Missing Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-029-01', N'If ''WagesLiteralCd'' in [WagesNotShownSchedule], has the value "FEC", then the corresponding ''WagesNotShownAmt'' must be equal to the sum of the ''ForeignEmployerCompensationAmt'' from all of the FEC Records present in the return.  When evaluating this a tolerance of $5 is allowed.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-033-02', N'The year of ''PrimaryDeathDt'' must not be less than ''TaxYr'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-034-02', N'The year of ''SpouseDeathDt'' must not be less than ''TaxYr'' in the Return Header.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-035-01', N'''PrimaryDeathDt'' in the return must match that in the e-File database.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-036-01', N'''SpouseDeathDt'' in the return must match that in the e-File database.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-037-01', N'If ''PrimaryDeathDt'' has a value, then the Filer address in the Return Header must not be a Foreign Address.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-038-01', N'If ''SpouseDeathDt'' has a value, then the Filer address in the Return Header must not be a Foreign Address.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-039-01', N'If ''ThirdPartyDesigneeInd'' in the return has a choice of ''Yes'' indicated, then ''ThirdPartyDesigneeNm'' must have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-040-01', N'If ''ThirdPartyDesigneeInd'' in the return has a choice of ''Yes'' indicated, then ''ThirdPartyDesigneePhoneNum'' must have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-042-01', N'If checkbox ''PowerOfAttorneySignedByInd'' is checked in the return, then checkbox ''SurvivingSpouseInd'' must not be checked.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-043-01', N'If checkbox ''PowerOfAttorneySignedByInd'' is checked in the return, then checkbox ''PersonalRepresentativeInd'' must not be checked.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-044-01', N'If checkbox ''PowerOfAttorneySignedByInd'' is checked in the return, then ''PrimaryDeathDt'' must not have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-045-01', N'If checkbox ''PowerOfAttorneySignedByInd'' is checked in the return, then ''SpouseDeathDt'' must not have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-049-01', N'Tax returns from the U.S. Possessions of American Samoa, Guam, U.S. Virgin Islands and the Commonwealth of the Northern Mariana Islands may not be electronically filed.', NULL, N'Unsupported', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-053-01', N'The ''IPAddress'' in the Return Header must not equal all zeros.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'IND-055-02', N'''AddressLine2Txt'' in the Return Header must not have a value.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-007-02', N'For US Addresses, the first five digits of ''ZipCd'' of the Filer''s address in the Return Header must be within the valid ranges of zip codes for the corresponding ''StateAbbreviationCd''. See Publication 4164.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-020-01', N'If the Filer has a US address in the Return Header and ''StateAbbreviationCd'' has the value "AA" then the first three digits of the ''ZipCd'' must be 340.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-022-01', N'If the Filer has a US address in the Return Header and ''StateAbbreviationCd'' has the value "AE" then the first three digits of the ''ZipCd'' must be in the range 090 - 098.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-024-01', N'If the Filer has a US address in the Return Header and ''StateAbbreviationCd'' has the value "AP" then first three digits of the ''ZipCd'' must be in the range 962 - 966.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-046-01', N'For US Addresses, the fourth and fifth digit of the ''ZipCd'' of the Filer''s address in the Return Header cannot both be zeros ("00"), except when the ''ZipCd'' is 00800, 20500, 34000, 00600, 96100, 96900.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-075-02', N'''RoutingTransitNum'' (RTN) must conform to the banking industry RTN algorithm.', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-116-02', N'If the Filer has a US address in the Return Header and if the value of ''CityNm'' is "APO" or "DPO" or "FPO", then ''StateAbbreviationCd'' must have the value "AA", "AE" or "AP".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-117-01', N'If the Filer has a US address in the Return Header and ''StateAbbreviationCd'' has the value "AA", "AE" or "AP" then the ''CityNm'' must be "APO" OR "DPO" OR "FPO".', NULL, N'Incorrect Data', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-503-02', N'''SpouseSSN'' and the ''SpouseNameControlTxt'' in the Return Header (or Line 6b ''ExemptSpouseNameControlTxt'' in the return - For 1040/1040A returns) must match the e-File database.', NULL, N'Database Validation Error', 3)
INSERT [dbo].[irs_error_code] ([irs_error_code ], [irs_error_response ], [irs_error_log_error_message], [irs_error_type ], [error_fix_type ]) VALUES (N'R0000-906-02', N'Routing Transit Number (RTN) included in the return must be present in the e-File database.', NULL, N'Database Validation Error', 3)
GO
/* 26Mar2014 Sathish added static data for email_template table */
/* 27Mar2014 Sathish Added @@login and replace @@email_id to @@email */
/* 28Mar2014 Bala Modified Email template t HTML forms and removed Temlate_id inserted manually.*/
/* 07May2014 Thileepkumar replaced All  Email template  HTML forms and removed old Temlate_id  manually.*/
/* 08May2014 vivekkumar Correct the email template as per the spec*/


/****** Object:  UserDefinedTableType [dbo].[role_feature]    Script Date: 10/04/2012 18:19:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON


GO
CREATE TYPE [dbo].[efile_error_code] AS TABLE
(
[efile_error_code] [nvarchar] (50) NOT NULL
)
GO

CREATE TABLE [dbo].[efile_error_message](
	[efile_error_id] [int] IDENTITY(1,1) NOT NULL,
	[efile_error_code] [nvarchar](50) NULL,
	[efile_error_message] [nvarchar](1000) NULL,
	[error_field_name] [nvarchar](255) NULL,
  CONSTRAINT [pk_efile_error_message] PRIMARY KEY ([efile_error_id]))
GO

CREATE PROCEDURE [dbo].[usp_get_efile_error_message]  
(  
  @efile_error_code efile_error_code readonly  
)  
AS  
BEGIN  
SET NOCOUNT ON;
   SELECT 
		eem.[efile_error_code],
		eem.[efile_error_message] 
		FROM
			[dbo].[efile_error_message] eem WITH(NOLOCK)
			INNER JOIN @efile_error_code eec 
			ON eem.[efile_error_code]= eec.[efile_error_code]


SET NOCOUNT OFF;
END
GO

--11 Aug 2014 Praveen T Added to include efile error messages.

INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-001-01', N'If Form 1040EZ, ''SpouseSSN'' has a value in the Return Header, then ''SpouseNameControlTxt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-002-02', N'The age of Primary tax payer on Form 1040EZ must be less than 65. If born January 01, 1949, taxpayer is considered to be age 65 at the end of 2013.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-003-02', N'If Form 1040EZ, ''SpouseSSN'' has a value in the Return Header, then Spouse''s age must be less than 65. If born January 01, 1949, taxpayer is considered to be age 65 at the end of 2013.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-004', N'Form 1040EZ,  Line 2 ''TaxableInterestAmt'' must not be greater than 1500.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-005', N'Form 1040EZ, Line 6 ''TaxableIncomeAmt'' must  be less than 100000.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-006', N'If Form 1040EZ, Line 8a ''EICEligibilityLiteralCd'' has the value ''NO'', then Line 8a ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-008', N'Form 1040EZ, Line 7 ''WithholdingTaxAmt'' must be equal to the sum of the following: (1) all ''WithholdingAmt'' in [OtherWithholdingStatement] attached to Form 1040EZ, Line 7 and (2) all of the Forms W-2, Line 2 ''WithholdingAmt''. When evaluating this a tolerance of $5.00 is allowed.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-009', N'The sum of all Forms W-2, Line 1 ''WagesAmt'' must not be greater than Form 1040EZ, Line 1 ''WagesSalariesAndTipsAmt''. When evaluating this, a tolerance of $5.00 is allowed.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-011', N'If Form 1040-EZ, Line 11a ''RefundAmt'' has a non-zero value, then Line 9 ''TotalPaymentsAmt'' must be greater than Line 10 ''TaxAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-012', N'If ''PrimarySSN'' in the Return Header is an ITIN, then Line 8a, ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-013', N'If ''SpouseSSN'' in the Return Header is an ITIN, then Line 8a, ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-016-02', N'If Form 1040EZ, Line 5 checkbox ''PrimaryClaimAsDependentInd'' is not checked and ''SpouseSSN'' in the Return Header does not have a value, then Line 5 ''CombStdDedAndPrsnlExemptAmt'' must be equal to 10000.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-017-02', N'If Form 1040EZ, Line 5 checkboxes ''PrimaryClaimAsDependentInd'' and ''SpouseClaimAsDependentInd'' are not checked and ''SpouseSSN'' in the Return Header has a value, then Line 5 ''CombStdDedAndPrsnlExemptAmt'' must be equal to 20000.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-018-02', N'If Form 1040EZ, Line 5 checkboxes ''PrimaryClaimAsDependentInd'' and ''SpouseClaimAsDependentInd'' are checked and ''SpouseSSN'' in the Return Header has a value, then Line 5 ''CombStdDedAndPrsnlExemptAmt'' must not be greater than 12200.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-019-02', N'If Form 1040EZ, Line 5 checkbox ''PrimaryClaimAsDependentInd'' is checked and ''SpouseSSN'' in the Return Header does not have a value, then Line 5 ''CombStdDedAndPrsnlExemptAmt'' must not be greater than 6100.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-020-02', N'Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' must not be greater than 487.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-021-02', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value and ''SpouseSSN'' in the Return Header does not have a value, then Line 4 ''AdjustedGrossIncomeAmt'' must be less than 14340.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-022-02', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value and ''SpouseSSN'' has a value in the Return Header, then Form 1040EZ, Line 4 ''AdjustedGrossIncomeAmt'' must be less than 19680.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-023', N'If Form 1040EZ, Line 5 checkbox ''PrimaryClaimAsDependentInd'' is checked, then Line 8a ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-024', N'If Form 1040EZ, Line 5 checkbox ''SpouseClaimAsDependentInd'' is checked, then Line 8a ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-026', N'If Form 1040-EZ, Line 2 ''TaxableInterestAmt'' has a zero value or has no entry, then Line 4 ''AdjustedGrossIncomeAmt'' must be equal to the sum of Line 1 ''WagesSalariesAndTipsAmt'' and Line 3 ''UnemploymentCompAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-027', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value, then the Primary Taxpayer and/or the Spouse Taxpayer in the Return Header must be at least 25 years old but not be older than 64.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-028', N'Form 1040EZ, Line 7 ''WithholdingTaxAmt'' must be less than the sum of the following: Line 1 ''WagesSalariesAndTipsAmt'' and Line 2 ''TaxableInterestAmt'' and Line 3 ''UnemploymentCompAmt'' unless  Combat Pay has been excluded from Wages.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-033', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value, then [FECRecord] must not be present in the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-044', N'Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' must have a zero value if an amount is entered.  e-File database indicates the taxpayer is not allowed to claim Earned Income Credit for this tax year.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-046', N'If the Filer address in the Return Header is a foreign address, then Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' must be equal to zero if an amount is entered.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-064', N'If Form 1040EZ, Line 8b ''NontxCombatPayElectionAmt'' has a non-zero value, then it must be equal to the sum of all Forms W-2 (for the Primary and/or Spouse), Line 12a ''EmployersUseAmt'' for which ''EmployersUseCd'' is equal to "Q".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-071-01', N'If ''SpouseSSN'' has a value in the Return Header, then ''SpousePINEnteredByCd'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-073-01', N'If Form 1040EZ, filing status is "Single" (''SpouseSSN'' does not have a value in the Return Header), then ''PrimarySignaturePIN'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-077-01', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' has a value and ''SpouseSignaturePIN'' does not have a value in the Return Header, then ''PrimarySignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-078-01', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' has a value and ''PrimarySignaturePIN'' does not have a value in the Return Header, then ''SpouseSignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-081-01', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingCodeTxt'' has a value and ''SpouseSignaturePIN'' does not have a value in the Return Header, then ''PrimarySignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-082-01', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingCodeTxt'' has a value and ''PrimarySignaturePIN'' does not have a value in the Return Header, then ''SpouseSignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-087-01', N'If Form 1040EZ, ''SpouseSSN'' has a value in the Return Header, then the Filer Name in the Return Header ''NameLine1Txt'' must contain an ampersand(&).')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-396', N'The e-File database indicates a First Time Homebuyer Installment Payment is due for the Primary SSN.  A Form 1040 must be filed, with the repayment amount included on Form 1040, Line 59b or Form 5405 must be attached to Form 1040.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-397', N'The e-File database indicates a First Time Homebuyer Installment Payment is due for the Spouse SSN. A Form 1040 must be filed, with the repayment amount included on Form 1040, Line 59b or Form 5405 must be attached to Form 1040.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-510', N'If Form 1040EZ, Line 5 checkbox ''PrimaryClaimAsDependentInd'' is not checked, then ''PrimarySSN'' in the Return Header must not be equal to a ''DependentSSN'' on another tax return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-511', N'Primary SSN in the Return Header must not be equal to the Spouse SSN on another tax return in which the Filing Status is "Married filing separately".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-513', N'If Form 1040EZ, Line 5 checkbox ''SpouseClaimAsDependentInd'' is not checked, then Spouse SSN in the Return Header must not be the same as a ''DependentSSN'' on another tax return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-524-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and Form 1040EZ, filing status is not "Married filing jointly" (''SpouseSSN'' does not have a value in the Return Header), then ''PrimaryBirthDt'' in the Return Header must match the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-003', N'Form 1310, ''DecedentSSN'' must be equal to ''PrimarySSN'' or the ''SpouseSSN'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-005', N'If two Forms 1310 are present in the Return, their ''DecedentSSN''s must not be equal.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-007-01', N'Form 1310, the year of ''DeathDt'' must not be less than ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-009', N'Form 1310, Part II, Line 2a ''CourtAppointedRepInd'' must have a choice of "No" indicated.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-010', N'Form 1310, Part II, Line 2b ''RepresentativeToBeAppointedInd'' must have a choice of "No" indicated .')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-011', N'Form 1310, Part II, line 3 ''PaymentAccordingToStateLawInd'' must have a choice of "Yes" indicated.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-012', N'Form 1310, ''RefundClaimantSSN'' must not be equal to the ''PrimarySSN'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-013', N'Form 1310, ''RefundClaimantSSN'' must not be equal to the ''SpouseSSN'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-016', N'If two Forms 1310 are present in the Return, their ''RefundClaimantSSN''s must be equal.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-518', N'Form 1310, Name Control of the person claiming refund ''PersonNameControlTxt'' and SSN of Person claiming Refund ''RefundClaimantSSN'' must match the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-001', N'There must be at least one checkbox ''InjuredSpouseInd'' checked on Form 8379, Line 10.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-002', N'There must be no more than one checkbox ''InjuredSpouseInd'' checked on Form 8379, Line 10.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-003', N'If Form 8379, Line 5 ''CommunityPropertyStateInd'' has a choice of "Yes" indicated, then Line 5 ''CommunityPropertyStateCd'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-004', N'If Form 8379, Line 13b(a) Joint Return ''TotalOtherIncomeAmt'' must be equal to the sum of Line 13b(b) Injured Spouse ''TotalOtherIncomeAmt'' and Line 13b(c) Other Spouse ''TotalOtherIncomeAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-005', N'If Form 8379, Line 15a Joint Return ''StandardOrItemizedDeductionAmt'' must be equal to the sum of Line 15b Injured Spouse  ''StandardOrItemizedDeductionAmt'' and Line 15c Other Spouse ''StandardOrItemizedDeductionAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-006', N'If Form 8379, Line 16a Joint Return ''AllocatedExemptionCnt'' must be equal to the sum of Line 16b Injured Spouse ''AllocatedExemptionCnt'' and Line 16c Other Spouse ''AllocatedExemptionCnt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-008', N'If Form 8379, Line 17a Joint Return ''CreditAmt'' must be equal to the sum of Line 17b Injured Spouse ''CreditAmt'' and Line 17c Other Spouse ''CreditAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-009', N'If Form 8379, Line 20a Joint Return ''EstimatedTaxPaymentAmt'' must be equal to the sum of Line 20b Injured Spouse ''EstimatedTaxPaymentAmt'' and Line 20c Other Spouse ''EstimatedTaxPaymentAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-011', N'If Form 8379 is present in the return, then Filer must not have a ''ForeignAddress'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-014', N'If Form 8379 is present in the return, then ''SpouseSSN'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-015', N'If Form 8379, Line 13a(a) Joint Return ''WagesAmt'' must be equal to the sum of Line 13a(b) Injured Spouse ''WagesAmt'' and Line 13a(c) Other Spouse ''WagesAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-016', N'If Form 8379, Line 14a Joint Return ''IncomeAdjustmentAmt'' must be equal to the sum of Line 14b Injured Spouse ''IncomeAdjustmentAmt'' and Line 14c Other Spouse ''IncomeAdjustmentAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-017', N'If Form 8379, Line 18a Joint Return ''OtherTaxesAmt'' must be equal to the sum of Line 18b Injured Spouse ''OtherTaxesAmt'' and Line 18c Other Spouse ''OtherTaxesAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-018', N'If Form 8379, Line 19a Joint Return ''FederalIncomeTaxWithheldAmt'' must be equal to the sum of Line 19b Injured Spouse ''FederalIncomeTaxWithheldAmt'' and Line 19c Other Spouse ''FederalIncomeTaxWithheldAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-020', N'If Form 8379 is present in the return, then Form 8833 or Form 8888 must not be present in the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8862-001-01', N'Form 8862, Line 1 ''EICEligClmFilingYr'' must be equal to ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-005', N'If Form 8888, Line 5c checkbox ''BeneficiaryInd'' is checked, then Line 5c ''BondCoOwnerOrBeneficiaryNm'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-007-01', N'Form 8888, Line 8 ''TotalAllocationOfRefundAmt'' must be equal to Form 1040EZ, Line 11a ''RefundAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-009', N'If Form 8888, Line 4 ''RefundUsedForBondPurchasesAmt'' has a non-zero value, then it must be a multiple of 50 and must not be greater than 5000.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-001-02', N'Form 9465, Line 9 ''TotalTaxDueAmt'' must not be greater than 50000.  If the tax due amount is greater than 50000, complete and mail Form 9465 with Form 433-F to the mailing address provided on www.irs.gov.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-014', N'Form 9465, Line 1 ''PrimarySSN'' must be equal to either the ''PrimarySSN'' or ''SpouseSSN'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-015', N'If Form 9465, Line 1 ''SpouseSSN'' has a value, then it must be equal to either the ''PrimarySSN'' or ''SpouseSSN'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-016-01', N'If Form 9465, Line 13a ''RoutingTransitNum'' has a value, then Line 13b ''BankAccountNum'' must also have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-017-01', N'If Form 9465, Line 13b ''BankAccountNum'' has a value, then Line 13a ''RoutingTransitNum'' must also have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-018-01', N'In Form 9465, one of the following must have a value: Line 3 Home ''PhoneNum'' or Line 4 Work ''PhoneNum'' or Line 3 Home ''ForeignPhoneNum'' or Line 4 Work ''ForeignPhoneNum''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-019-01', N'If IRS Payment Record is present in the return, then Form 9465, Line 8 ''PaymentAmt'' must be equal to ''PaymentAmt'' in IRS Payment Record.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-020-01', N'If Form 9465, Line 1a ''SpouseName'' has a value, then ''SpouseNameControlTxt'' must also have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-026', N'Form 9465, Line 14 checkbox ''PayrollDeductionAgreementInd'' must not be checked.  If the Payroll Deduction Agreement box is checked, complete and mail Form 9465 with Form 2159 to the mailing address provided on www.irs.gov.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-027', N'Form 9465, Line 10 ''PaymentDueAmt'' can not be less than Line 11 ''CalculatedMonthlyPymtAmt''.  If the payment due amount is less than Line 11, calculated monthly payment amount, complete and mail Form 9465 with Form 433-F to the mailing address provided on www.irs.gov.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-029', N'If Form 9465 is attached to Form 1040 or Form 1040A or Form 1040EZ or Form 1040PR or Form 1040SS, then ''F9465TaxReturnTypeCd'' must not have the following values: "FORM 940" or "FORM 940PR" or "FORM 941" or "FORM 941PR" or "FORM 941SS" or "FORM 943" or "FORM 943PR" or "FORM 944" or "FORM 945" or "FORM 720" or "FORM 2290".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F9465-030', N'If Form 9465 ''F9465TaxReturnTypeCd'' has a value of "FORM 1040" or "FORM 1040A" or "FORM 1040EZ" or "FORM 1040SS" or "FORM 1040PR", then ''IATaxYrDt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-043-04', N'If the processing date is after June 21, 2014, but prior to September 21, 2014, then the ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be September 15, 2014 or January 15, 2015.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-044-04', N'If the processing date is after September 20, 2014, but prior to January 1, 2015, then the ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be January 15, 2015.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-045-02', N'''EstimatedPaymentDueDt'' in the IRS ES Payment Record must not be the same as another IRS ES Payment Record filed with the same return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-046-04', N'If the processing date is after December 31, 2013, but prior to January 16, 2014, then the ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be April 15, 2014 or June 16, 2014 or September 15, 2014.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-047-04', N'If the processing date is after April 20, 2014, but prior to June 22, 2014, then the ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be June 16, 2014 or September 15, 2014 or January 15, 2015.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-056-03', N'If the processing date is after January 15, 2014, but prior to April 21, 2014, then ''EstimatedPaymentDueDt'' in the IRS ES Payment Record must be April 15, 2014 or June 16, 2014 or September 15, 2014 or January 15, 2015.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-068-01', N'''PaymentAmt'' in the IRS Payment Record must not be greater than 99,999,999.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-069-01', N'''PaymentAmt'' in the IRS ES Payment Record must not be greater than 99,999,999.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-071-01', N'''RequestedPaymentDt'' in the IRS Payment Record must not be more than 5 days prior to the received date.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-072-01', N'If the return is received on or before the due date of the return, then the ''RequestedPaymentDt'' in the IRS Payment Record must be on the due date or before the due date.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-074-01', N'If the return is received after the due date of the return, then the ''RequestedPaymentDt'' in the IRS Payment Record must not be later than the date the return was received.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-086', N'''EstimatedPaymentDueDt'' in the IRS ES Payment Record must not be more than 5 days prior to the received date.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-087', N'''EstimatedPaymentDueDt'' in the IRS ES Payment Record must not be more than one year after the received date.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FW2-002', N'Form W-2, Line 1 ''WagesAmt'' must have a value greater than zero unless Combat Pay has been excluded from income.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FW2-003-01', N'Form W-2, Line a, ''EmployeeSSN'' must be equal to ''PrimarySSN'' or ''SpouseSSN'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FW2-499', N'Form W-2, Line B ''EmployerEIN'' is invalid for processing an Individual e-filed return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FW2-502', N'Form W-2, Line B ''EmployerEIN'' must match data in the eFile database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FW2-505-01', N'Form W-2, Line B ''EmployerEIN'' was issued after the Tax Year in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-001-01', N'''PreparerSSN'' in the Return Header must not be all zeros or all nines.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-002', N'The ''TaxPeriodEndDate''  in the Submission Manifest must be less than the "Received Date".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-005-01', N'If Form 9465 and IRS Payment Record are present in the return, then Form 9465, ''PaymentAmt'' must be equal to ''PaymentAmt'' in IRS Payment Record.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-006', N'''SpouseSSN'' in the Return Header must not be equal to ''PrimarySSN'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-007-01', N'If checkbox ''ProtectiveSec108iELCRecordInd'' is checked in the return, then [GeneralDependencyMedium] with Description beginning with ''Section 108(i) election explanation'' must be attached to the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-010', N'''TaxYear'' must equal the year of the ''TaxPeriodBeginDate'' ("YYYY" digits) in the Submission Manifest.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-011', N'''TaxYear'' must equal the year of the ''TaxPeriodEndDate'' ("YYYY" digits) in the Submission Manifest.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-013-01', N'In the Return Header, ''PreparerSSN'' or ''PTIN'' or ''STIN'' or ''PreparerFirmEIN'' must have a value, if any one of the following is true: (1) checkbox ''SelfEmployedInd'' is checked; (2) ''PreparerPersonNm'' or ''PreparerFirmName'' or ''PreparerUSAddress'' or ''PreparerForeignAddress'' has a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-015', N'If checkbox ''WorkPerformedResidingInUSInd'' is checked in [FECRecord], then ''USAddress'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-016', N'If ''USAddress'' has a value in [FECRecord], then checkbox ''WorkPerformedResidingInUSInd'' must be checked.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-020-01', N'If ''PaidPreparerInformationGrp'' is present in the Return Header, then ''NonPaidPreparerCd'' must not have a value in the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-021-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and ''PrimarySignaturePIN'' has a value, then ''PrimaryBirthDt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-022-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and ''SpouseSignaturePIN'' has a value, then ''SpouseBirthDt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-023-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner" and ''PrimarySignaturePIN'' has a value, then ''PrimaryBirthDt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-024-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner" and ''SpouseSignaturePIN'' has a value, then ''SpouseBirthDt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-025-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line", and ''PrimaryBirthDt'' has a value, then ''PrimaryPriorYearAGIAmt'' or ''PrimaryPriorYearPIN'' or ''PrimaryElectronicFilingPIN'' or ''IdentityProtectionPIN'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-026-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner", and ''PrimaryBirthDt'' has a value, then ''PrimaryPriorYearAGIAmt'' or ''PrimaryPriorYearPIN'' or ''PrimaryElectronicFilingPIN'' or ''IdentityProtectionPIN'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-027-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line", and ''SpouseBirthDt'' has a value, then ''SpousePriorYearAGIAmt'' or ''SpousePriorYearPIN'' or ''SpouseElectronicFilingPIN'' or ''SpouseIdentityProtectionPIN'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-028-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner", and ''SpouseBirthDt'' has a value, then ''SpousePriorYearAGIAmt'' or ''SpousePriorYearPIN'' or ''SpouseElectronicFilingPIN'' or ''SpouseIdentityProtectionPIN'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-031-01', N'''PrimaryPriorYearPIN'' or ''PrimaryElectronicFilingPIN'' or ''PrimaryPriorYearAGIAmt'' in the Return Header must match the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-032-01', N'''SpousePriorYearPIN'' or ''SpouseElectronicFilingPIN'' or ''SpousePriorYearAGIAmt'' in the Return Header must match the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-041', N'If ''ThirdPartyDesigneeInd'' in the return has a choice of ''Yes'' indicated, then ''ThirdPartyDesigneePIN'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-046', N'Form 8862 must be present in the return.  e-File database indicates the taxpayer must file Form 8862 to Claim Earned Income Credit after disallowance.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-052', N'The TIN present in the IRS Submission Manifest must be equal to the Primary SSN in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-056-01', N'If ''PrimarySignaturePIN'' has a value in the Return Header, then ''PrimaryPINEnteredByCd'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-057-01', N'If ''SpouseSignaturePIN'' has a value in the Return Header, then ''SpousePINEnteredByCd'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-058-01', N'If ''PrimarySignaturePIN'' has a value in the Return Header, then ''PrimarySignatureDt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-059-01', N'If ''SpouseSignaturePIN'' has a value in the Return Header, then ''SpouseSignatureDt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-060', N'''IdentityProtectionPIN'' in the Return Header must not equal all zeroes.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-061', N'IRS ES Payment Record must not be present in a prior year return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-062', N'IP Address of the Transmitter must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-063', N'Timestamp of the Transmitter must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-064', N'IP Address of the Transmitter must be a valid IP Address.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-066', N'''SpouseIdentityProtectionPIN'' in the Return Header must not equal all zeroes.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-067', N'As a paid tax preparer of a tax return claiming Earned income Tax Credit, you must complete and submit Form 8867 to IRS with the original submission of each return. Failure to submit Form 8867 is a violation of IRC Sec 6695(g) and a $500 penalty may be imposed per return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-180', N'Primary taxpayer''s Identity Protection Personal Identification Number (IP PIN) must match the e-File database.  Please double check your entry and resubmit your return with the correct number.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-181', N'The Primary Taxpayer did not enter a valid Identity Protection Personal Identification Number (IP PIN).  Please  visit www.irs.gov/get-an-ippin for further information and resubmit your return with the correct number.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-182', N'The Spouse Identity Protection Personal Identification Number (IP PIN) must match the e-File database. Please double check your entry and resubmit your return with the correct number.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-183', N'The Spouse did not enter a valid Identity Protection Personal Identification Number (IP PIN).  Please  visit www.irs.gov/get-an-ippin for further information and resubmit your return with the correct number.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-508', N'Primary SSN in the Return Header must not be equal to the Spouse SSN on another tax return  for which filing status is Married Filing Jointly or  [filing status is Married Filing Separately and the Spouse exemption is claimed].')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-510', N'Spouse SSN in the Return Header must not be equal to the Primary SSN on another tax return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-513', N'The Spouse SSN in the Return Header must not be equal to the Spouse SSN in another return filed for the same tax year.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-515', N'The Primary SSN in the Return Header must not be equal to the Primary SSN in another return filed for the same tax year.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-521-01', N'The Year of Birth of the Primary SSN must not be greater than the ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-531-01', N'If Primary Date of Death has a value in the e-File database, then it must not be prior to the ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-532-01', N'If Spouse Date of Death has a value in the e-File database, then it must not be prior to the ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-570-01', N'The Year of Birth of the Spouse SSN must not be greater than the ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-664-01', N'If the Primary SSN appears more than once in the e-File database, then ''PINTypeCd'' in the Return Header must not have the value "Self-Select On-Line".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-665-01', N'If the Primary SSN appears more than once in the e-File database, then ''PINTypeCd'' in the Return Header must not have the value "Self-Select Practitioner".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-666-01', N'If the Spouse SSN appears more than once in the e-File database, then ''PINTypeCd'' must not have the value "Self-Select On-Line".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-667-01', N'If the Spouse SSN appears more than once in the e-File database, then ''PINTypeCd'' must not have the value "Self-Select Practitioner".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-672-01', N'In the Return Header, if ''PINTypeCd'' has the value "Practitioner" or "Self-Select Practitioner", then ''PractitionerPINGrp'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-673-01', N'In the Return Header, if ''PINTypeCd'' has the value "Self-Select On-Line", then ''PractitionerPINGrp'' must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-674-01', N'If the Primary Taxpayer  is under the age of 16 and has never filed a tax return, then ''PINTypeCd'' in the Return Header must not have the value "Self-Select On-Line".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-675-01', N'If the Primary Taxpayer  is under the age of 16 and has never filed a tax return, then ''PINTypeCd'' in the Return Header must not have the value "Self-Select Practitioner".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-679-01', N'If the Spouse SSN in the Return Header is under the age of 16 and did not file a tax return in the previous year, then the ''PINTypeCd'' must not have the value "Self-Select On-Line".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-680-01', N'If the Spouse SSN in the Return Header is under the age of 16 and did not file a tax return in the previous year, then the ''PINTypeCd'' must not have the value "Self-Select Practitioner".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-689-01', N'The year of the ''PrimarySignatureDt'' in the Return Header must be equal to the processing year.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-694-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select Practitioner", then ''JuratDisclosureCd'' must have the value "Self Select PIN By ERO".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-695-01', N'If ''PINTypeCd'' in the Return Header has the value "Practitioner", then ''JuratDisclosureCd'' must have the value "Practitioner PIN".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-696-01', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line", then ''JuratDisclosureCd'' must have the value "Online Self Select PIN".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-699-01', N'If ''PINTypeCd'' in the Return Header has the value "Practitioner", then the following must not have an entry: ''PrimaryPriorYearAGIAmt'' and ''PrimaryPriorYearPIN'' and ''PrimaryElectronicFilingPIN'' and ''SpousePriorYearAGIAmt'' and ''SpousePriorYearPIN'' and ''SpouseElectronicFilingPIN''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-769', N'''IdentityProtectionPIN'' in the Return Header must be numeric digits.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-770', N'''SpouseIdentityProtectionPIN'' in the Return Header must be numeric digits.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-901', N'The Primary SSN in the Return Header has been locked because Social Security Administration records indicate the number belongs to a deceased individual.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-902', N'The Primary SSN in the Return Header has been locked.  The account was locked per the taxpayer''s request.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-904', N'The Primary SSN in the Return Header has been locked.  Social Security Administration records indicate the SSN belongs to a minor.  The account was locked per the request of the minor''s parent or guardian.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-941', N'The Spouse SSN in the Return Header has been locked because Social Security Administration records indicate the number belongs to a deceased individual.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-942', N'The Spouse SSN in the Return Header has been locked.  The account was locked per the taxpayer''s request.   ')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-943', N'The Spouse SSN in the Return Header has been systemically locked based on IRS information which indicates there is not a filing requirement for this SSN.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-944', N'The Spouse SSN in the Return Header has been locked.  Social Security Administration records indicate the SSN belongs to a minor.  The account was locked per the request of the minor''s parent or guardian.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-003', N'The return version (attribute ''returnVersion'' of the Return element) must be specified for each return in the return header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-004-01', N'''ReturnTypeCd'' (specified in the Return Header) and the return version (specified by the ''returnVersion'' attribute of the ''Return'' element) of the return must match the return type and the version supported by the Modernized e-File system.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-019', N'The number of return documents (forms, schedules, and supporting documents) included in the return must equal the document count specified in the Return Data (documentCount attribute of the ReturnData element of the Return).')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-030-01', N'In the Return Header, if ''PractitionerPINGrp'' is provided, then ''EFIN'' in the ''PractitionerPINGrp'' must be the same as ''EFIN'' in the ''OriginatorGrp''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-051-01', N'''FederalSubmissionType'' in the IRS Submission Manifest must match ''ReturnTypeCd'' indicated in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-052-01', N'''TaxYear'' specified in the IRS Submission Manifest must match ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-054-01', N'The ''EFIN'' in the IRS Submission Manifest must match ''EFIN'' in the ''OriginatorGrp'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-057', N'Every attached file (i.e. binary attachment) must be referenced by the XML document that represents it.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-058', N'An XML document that represents a binary attachment must have a valid reference to an attached file.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-060', N'The EFIN in the Submission ID (the first six digits) must match the EFIN in the Submission Manifest.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-067', N'The attached files (i.e. binary attachments) in a submission zip archive must have distinct names.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-080-01', N'''TaxPeriodBeginDate'' present in the IRS Submission Manifest must match ''TaxPeriodBeginDt'' provided in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-081-01', N'The TaxPeriodEndDate present in the IRS Submission Manifest must match ''TaxPeriodEndDt'' provided in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-082', N'The TaxPeriodBeginDate and TaxPeriodEndDate must be provided in the IRS Submission Manifest.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-087-02', N'''PreparerFirmEIN'' in the Return Header must not equal all zeros or all nines.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-088-01', N'The eight numeric digits of the PTIN (of the Paid Preparer) following the letter P, must not equal all zeros or all nines in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-092-01', N'''PrimarySSN'' in the Return Header must be within the valid range of SSN/ITIN and must not be an ATIN.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-093-01', N'If ''SpouseSSN'' in the Return Header has a value, then it must be within the valid range of SSN/ITIN and must not be an ATIN.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-095-02', N'''PrimarySignaturePIN'' in the Return Header must not equal all zeros.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-096-02', N'''SpouseSignaturePIN'' in the Return Header must not equal all zeros.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-113-01', N'The eight numeric digits of the STIN (of the Paid Preparer) following the letter S, must not equal all zeros or all nines in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-114', N'The Submission Manifest''s ''TaxPeriodBeginDate'' value for month and day should be January 1.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-115', N'The Submission Manifest''s ''TaxPeriodEndDate'' value for month and day should be December 31.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-118-01', N'If first two digits of the EFIN in the IRS Submission Manifest are 10, 21, 32, 44 or 53, then ''OriginatorTypeCd'' in the Return Header must have the value "OnlineFiler".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-119-01', N'If ''OriginatorTypeCd'' in the Return Header has the value "OnlineFiler", then the first two digits of the EFIN in the IRS Submission Manifest must be 10 or 21 or 32 or 44 or 53.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-120', N'The IRS Submission type that was filed is not being accepted by Modernized e-File (MeF) at this time.  Please check the MeF web page under irs.gov for more information.  The submission type filed was <type>.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-121', N'The ETIN associated with the Individual submission is not a participating transmitter.  Please check the Modernized e-File (MeF) web page under irs.gov for more information on participation rules.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-123-01', N'If ''NameLine1Txt'' in the Return Header contains an ampersand, then ''SpouseSSN'' in the Return Header must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-125-01', N'''NameLine1Txt'' in the Return Header must contain a less-than sign (<).')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-126-01', N'There can be no more than two less-than signs (<) in ''NameLine1Txt'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-127-01', N'The character following the first less-than sign in ''NameLine1Txt'' in the Return Header must be an alphabetic character.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-129-01', N'The 4th and 5th digits of the ''PrimarySSN'' in the Return Header must be equal to "00" for testing.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-130-01', N'The 4th and 5th digits of the ''SpouseSSN'' in the Return Header must be equal to "00" for testing.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-142-01', N'If you are a paid tax return preparer, you must use a Preparer Tax Identification Number (PTIN) issued by the Internal Revenue Service (IRS) to identify yourself in the paid preparer section of the tax return.  In future years, tax returns may be rejected if an SSN, or any number that is not a valid PTIN, is included in this field.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-143', N'Tax Year in the IRS Submission Manifest must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-180', N'''TaxYear'' specified in the Submission Manifest must equal the year of the schema version (''YYYY'' digits of the attribute ''returnVersion'' of the Return) that is being used to file the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-192', N'Phone Number provided in the return must not be all zeros.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-193', N'Bank Account Number provided in the return must not be all zeros.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-194', N'Return must not be a duplicate of a previously accepted return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-500-01', N'''PrimarySSN'' and ''PrimaryNameControlTxt'' in the Return Header must match the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-902-01', N'Taxpayer TIN in the Return Header must not be the same as a TIN of a previously accepted electronic return for the return type and tax period indicated in the tax return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-904-03', N'Software ID in the Return Header must have passed testing for the form family and ''TaxYr''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-905-01', N'Electronic Filing Identification Number (EFIN) in the Return Header must be listed in the e-File database and in accepted status.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-001', N'The agency to which a State Submission is filed must participate in the Fed/State program.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-005', N'The Submission Category of  a State Submission  must match Submission Category of the referenced IRS Submission.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-006', N'If IRS Submission ID is not provided in the State Submission Manifest, the State must participate in the State Stand Alone Program.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-007', N'The IRS Submission ID referenced in the State Submision must be that of an IRS Return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-010', N'The Tax Year referenced in the State Submission Manifest must match the Tax Year of the linked Federal return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-011', N'An SSN (either the Primary or the Spouse) referenced in the State Submission Manifest must match an SSN (either the Primary or the Spouse) of a linked Federal return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-012', N'The State Submission category that was filed is not being accepted by Modernized e-File (MeF) at this time.  Please check the MeF web page under irs.gov for more information.  The submission category filed was <category>.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-013', N'The ETIN associated with the Individual submission is not a participating transmitter.  Please check the Modernized e-File (MeF) web page under irs.gov for more information on participation rules.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-015', N'If the Submission Category in the State Submission Manifest has a value of ("CORP" or "PART" or "IND" or "EO" or "ESTRST"), then ''TaxYear''  in the State Submission Manifest must be be valid for the current or prior year returns that are being accepted by Modernized e-File (MeF).')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-016', N'If the Submission Category in the State Submission Manifest has a value of ("CORPEP" or "PARTEP" or "INDEP"or "ESTRSTEP"), then ''TaxYear''  in the State Submission Manifest must be the same as processing year.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-017', N'If the Submission Category in the State Submission Manifest has a value of ("CORPEP" or "PARTEP" or "INDEP"or "ESTRSTEP"), then ''IRSSubmissionId'' in the State Submission Manifest must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-019', N'In the State Submission Manifest, if the Submission Category has a value of ("IND" or "INDEP"), then ( ''PrimarySSN''  and ''PrimaryNameControl'' ) or ''TempID'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-901', N'The IRS Submission ID referenced in the State Submission Manifest must be present in the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-902', N'The IRS Submission ID referenced in the State Submission Manifest must be in accepted status.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'STATE-903', N'Electronic Filing Identification Number (EFIN) in the State Submission Manifest must be approved and present in the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'T0000-013', N'The Message ID must be globally unique.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'T0000-014', N'The Submission ID must be globally unique.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'T0000-015', N'The ETIN in the Message ID (the first five digits) must match the ETIN provided with the request.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'T0000-016', N'The Message ID must be 20 positions in length and conform to the following format: 12 digits followed by 8 alphanumeric characters (only lower case alphabetic characters allowed).')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'T0000-017', N'The Submission ID must be 20 characters in length.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'T0000-900', N'Transmission cannot be a duplicate of a previously accepted transmission.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-005', N'The XML data has failed schema validation.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-008', N'The namespace declarations in the root element of the return (''Return'' element) must be as follows:The default namespace shall be set to  "http://www.irs.gov/efile" (xmlns= "http://www.irs.gov/efile").The namespace prefix "efile" shall be bound to the namespace  "http://www.irs.gov" (xmlns:efile="http://www.irs.gov/efile").')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-009', N'The SOAP envelope structure in the Transmission file must conform to the SOAP 1.1 specification.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-010', N'For each SubmissionID provided in the transmission manifest there must be a submission zip archive entry present in the Attachment Zip file whose name (without the ".zip" extension) matches the SubmissionID.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-011', N'All entries in the submission zip archive (zip file that is the submission) must begin with "manifest/" or "/manifest/" or "xml/" or "/xml/" or "attachment/" or  "/attachment/" (all lower case characters).')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-012', N'The name of a binary attachment file must be less than or equal to 64 bytes.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-015', N'Each zip entry in the Attachment Zip file must end with ".zip" extension.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-017', N'ZIP Entry names in the transmission ZIP archive must be unique.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-018', N'A submission zip archive (zip file that is the submission) must contain exactly one entry that begins with  "manifest/" or "/manifest/" and is followed by the file name "manifest.xml".  The entry name must use lower case characters (''a'' through ''z'') only and the separator must be the forward slash character.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-019', N'A submission zip archive (zip file that is the submission) must contain exactly one entry that consists of "xml/" or "/xml/" (all lower case characters) followed by a file name.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-020', N'A submission zip archive (zip file that is the submission) may contain zero or more entries that begin with "attachment/" or "/attachment/" and each is followed by a file name.  The entry name must use lower case characters (''a'' through ''z'') only and the separator must be the forward slash character.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-021', N'The submission zip archive entries (zip files) in the container zip file must be in the root directory of the container zip file.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-022', N'The names of ZIP Entries (files) within the attachments zip file (the container zip file that contains zip files for all submission) must be unique.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-024', N'Unable to read a binary attachment in the Submission Zip Archive.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-025', N'Unable to read XML data from the Submission Zip Archive.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-026', N'The count of SubmissionIDs provided in the transmission manifest must match the count of submission zip archive entries in the Attachment Zip file.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-027', N'Year (YYYY) in the SubmissionID must be processing year.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-028', N'A single PDF file must not exceed 60MB in size.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-029', N'A binary attachment submitted in the PDF format must begin with the file header "%PDF-".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-030', N'The size and CRC32 checksum value must be provided for the submission XML file (i.e. xml data file that starts with "xml/" or "/xml/").')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-031', N'Zip Entry names must consist of ASCII characters only.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-032', N'Unable to extract submission Zip Archive from the Message Attachment zip file.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'X0000-033', N'Modernized e-File (MeF) accepts submissions only in the Unicode Transformation Format-8 (UTF-8) format.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-007-01', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value, then [ in [WagesNotShownSchedule] attached to Line 1, at least one ''WagesLiteralCd'' must have the value "HSH" and the corresponding  ''WagesNotShownAmt'' must be greater than zero ] or Form W-2 must be present in the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-010-01', N'If any of the following Form 1040-EZ fields have a value, then all of these fields must have a value: Line 11b ''RoutingTransitNum'' and Line 11c  ''BankAccountTypeCd'' and Line 11d ''DepositorAccountNum''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-025-01', N'At least one of the following lines on Form 1040EZ must have a non-zero value: Line 4 ''AdjustedGrossIncomeAmt'' or Line 9 ''TotalPaymentsAmt'' or Line 10 ''TaxAmt'' or Line 11a ''RefundAmt'' or Line 12 ''OwedAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-029-01', N'If Form 1040EZ, Line 12 ''OwedAmt'' has a non-zero value, then Line 10 ''TaxAmt'' must be greater than Line 9 ''TotalPaymentsAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-034-01', N'If Form 1040EZ, Line 8a ''EarnedIncomeCreditAmt'' has a non-zero value, then ''WagesLiteralCd'' in [WagesNotShownSchedule] must not have the value "FEC".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-049-01', N'If ''SpouseSSN'' is has a value in the Return Header,  and on Form 1040EZ, [both ''PrimaryDeathDt'' and ''SpouseDeathDt'' has a value] and Line 11a ''RefundAmt'' has a non-zero value, then two Forms 1310 must be present in the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-050-01', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value, then Form 1040EZ, ''SurvivingSpouseInd'' must be checked.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-051-01', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''SpouseDeathDt'' has a value, then Form 1040EZ, ''SurvivingSpouseInd'' must be checked.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-052-01', N'If ''SpouseSSN'' does not have a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value and Line 11a ''RefundAmt'' has a non-zero value, then no more than one Form 1310 must be present in the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-054-01', N'If ''SpouseSSN'' does not have a value in the Return Header, and on Form 1040EZ, both  ''PrimaryDeathDt'' and ''SpouseDeathDt'' has a value, then Form 1040EZ ''PersonalRepresentativeInd'' must be checked.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-061-02', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value, then the Filer name in the Return Header ''NameLine1Txt'' must contain either " DECD" or "<DECD".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-062-02', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value, then the Filer name in the Return Header ''NameLine1Txt'' must contain "DECD &".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-063-02', N'If ''SpouseSSN'' has a value in the Return Header and Form 1040EZ, ''SpouseDeathDt'' has a value, then the Filer name in the Return Header ''NameLine1Txt'' must contain " DECD".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-065-01', N'Form 8888 must not be present in the return if any one of the following lines of Form 1040EZ has a value: Line 11b ''RoutingTransitNum'' or Line 11c ''BankAccountTypeCd'' or Line 11d ''DepositorAccountNum''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-074-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''PrimaryDeathDt'' does not have a value, then ''PrimarySignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-075-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''SpouseDeathDt'' does not have a value, then ''SpouseSignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-076-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''PrimaryDeathDt'' has a value and ''SpouseDeathDt'' has a value, then ''PrimarySignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-079-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''CombatZoneCd'' has a value and ''SpouseSignaturePIN'' does not have a value in the Return Header, then ''PrimarySignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-080-02', N'If Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''CombatZoneCd'' has a value and ''PrimarySignaturePIN'' does not have a value in the Return Header, then ''SpouseSignaturePIN'' must have a value in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-088-01', N'If Form 1040EZ, ''SpouseSSN'' has a value in the Return Header and both ''PrimaryDeathDt'' and ''SpouseDeathDt'' have a value, then checkbox ''PersonalRepresentativeInd'' must be checked.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-336-01', N'If ''SpouseSSN'' does not have a value in the Return Header and Form 1040EZ, ''PrimaryDeathDt'' has a value and Line 11a ''RefundAmt'' has a non-zero value, then Form 1310 must be attached to Form 1040EZ.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-402-01', N'If [FEC Record] is present in the return, then in [WagesNotShownSchedule], there must be at least one ''WagesLiteralCd'' that has the value "FEC".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-411-01', N'If Form 1040EZ, Line 12 ''OwedAmt'' has a value greater than zero, then Line 11a ''RefundAmt'' must be equal to zero if an amount is entered.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-412-01', N'If Form 1040EZ, Line 11a ''RefundAmt'' has a value greater than zero, then Line 12 ''OwedAmt'' must be equal to zero if an amount is entered.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-525-02', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''PrimaryDeathDt'' does not have a value, then ''PrimaryBirthDt'' in the Return Header must match the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1040EZ-526-02', N'If ''PINTypeCd'' in the Return Header has the value "Self-Select On-Line" and Form 1040EZ, filing status is "Married filing jointly" (''SpouseSSN'' has a value in the Return Header) and ''SpecialProcessingLiteralCd'' does not have a value and ''CombatZoneCd'' does not have a value and ''SpecialProcessingCodeTxt'' does not have a value and ''SpouseDeathDt'' does not have a value, then ''SpouseBirthDt'' in the Return Header must match the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-006-02', N'Form 1310, ''RefundDueTaxYr'' must be equal to ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F1310-008-01', N'Form 1310, ''DeathDt'' must be the same as ''PrimaryDeathDt''  or ''SpouseDeathDt'' in the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8379-012-01', N'If Form 8379 is present in the return, then the ''StateAbbreviationCd'' of Filer address in the Return Header must not have the value "PR" or "VI".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8862-002-01', N'For each Form 8862, Line 4, ''EICEligClmDaysChldLivedInUSCnt'' that has a value less than 183 days, the corresponding Line 5  ''EICEligClmChildBirthMonthDayDt'' or Line 5 ''EICEligChildDeathMonthDayDt'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8862-003-01', N'If Form 8862, Line 7 ''EICEligClmLivedWithOthersInd'' has a choice of "Yes" indicated, then there must be at least one ''EICEligClmOtherPersonNm''  and ''EICEligClmOtherPersonRlnDesc'' with a value among Line 7a, 7b and 7c.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-001-03', N'The sum of all amounts on Form 8888, Line 1a ''DirectDepositRefundAmt'' and Line 4 ''RefundUsedForBondPurchasesAmt'' and Line 5a ''BondPurchaseAmt'' and Line 7 ''RefundByCheckAmt'' must be equal to Line 8 ''TotalAllocationOfRefundAmt''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-010-01', N'If Form 8888, Line 4 ''RefundUsedForBondPurchasesAmt'' has a non-zero value, then (Form 1040 or Form 1040A or Form 1040EZ or Form 1040-SS or Form 1040-PR) ''PrimaryDeathDt'' must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-011-01', N'If Form 8888, Line 4 ''RefundUsedForBondPurchasesAmt'' has a non-zero value, then (Form 1040 or Form 1040A or Form 1040EZ or Form 1040-SS or Form 1040-PR) ''SpouseDeathDt'' must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-012-01', N'For each Bond Purchase information on Form 8888, if Line 5a ''BondPurchaseAmt'' has a value, then it must be a multiple of 50 and must not be greater than 5000.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-013-01', N'For each Bond Purchase information on Form 8888, if Line 5a ''BondPurchaseAmt'' has a value, then (Form 1040 or Form 1040A or Form 1040EZ or Form 1040-SS or Form 1040-PR) ''PrimaryDeathDt'' must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8888-014-01', N'For each Bond Purchase information on Form 8888, if Line 5a ''BondPurchaseAmt'' has a value, then (Form 1040 or Form 1040A or Form 1040EZ or Form 1040-SS or Form 1040-PR) ''SpouseDeathDt'' must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8965-001', N'If Form 8965, Part III, Line d checkbox ''AllYearInd'' is not checked, then at least one of the following checkboxes in ''MonthIndicatorGrp'' must be checked: Line e ''JanuaryInd'' or Line f ''FebruaryInd'' or Line g ''MarchInd'' or Line h ''AprilInd'' or Line i ''MayInd'' or Line j ''JuneInd'' or Line k ''JulyInd'' or Line l ''AugustInd'' or Line m ''SeptemberInd'' or Line n ''OctoberInd'' or Line o ''NovemberInd'' or Line p ''DecemberInd''.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'F8965-004', N'Form 8965, ''SSN'' must be equal to ''PrimarySSN'' or ''SpouseSSN'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FPYMT-064-02', N'''PaymentAmt'' in the IRS Payment Record must not be more than 200% of the Form 1040EZ, Line 12 ''OwedAmt'' amount. If a value is not provided on Form 1040EZ, Line 12, treat that value as zero.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FW2-007-01', N'''CityNm'' of Form W-2, Line C ''EmployerUSAddress'' must contain at least three characters.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'FW2-008-01', N'''CityNm'' of Form W-2, Line C ''EmployerForeignAddress'' must contain at least three characters.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-012-01', N'If ''WagesLiteralCd'' in [WagesNotShownSchedule] has the value  "FEC", then [FECRecord] must be present in the return.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-014-02', N'''EmployeeTIN'' and ''EmployeeNameControlTxt'' in [FECRecord] must be the same as [ ''PrimarySSN'' and ''PrimaryNameControlTxt'' ] or [''SpouseSSN'' and ''SpouseNameControlTxt'' ] in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-018-02', N'If ''PrimaryDeathDt'' has a value in the return, then ''InCareOfNm'' in the Filer address in the Return Header must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-019-02', N'If ''SpouseDeathDt'' has a value in the return, then ''InCareOfNm'' in the Filer address in the Return Header must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-029-01', N'If ''WagesLiteralCd'' in [WagesNotShownSchedule], has the value "FEC", then the corresponding ''WagesNotShownAmt'' must be equal to the sum of the ''ForeignEmployerCompensationAmt'' from all of the FEC Records present in the return.  When evaluating this a tolerance of $5 is allowed.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-033-02', N'The year of ''PrimaryDeathDt'' must not be less than ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-034-02', N'The year of ''SpouseDeathDt'' must not be less than ''TaxYr'' in the Return Header.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-035-01', N'''PrimaryDeathDt'' in the return must match that in the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-036-01', N'''SpouseDeathDt'' in the return must match that in the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-037-01', N'If ''PrimaryDeathDt'' has a value, then the Filer address in the Return Header must not be a Foreign Address.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-038-01', N'If ''SpouseDeathDt'' has a value, then the Filer address in the Return Header must not be a Foreign Address.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-039-01', N'If ''ThirdPartyDesigneeInd'' in the return has a choice of ''Yes'' indicated, then ''ThirdPartyDesigneeNm'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-040-01', N'If ''ThirdPartyDesigneeInd'' in the return has a choice of ''Yes'' indicated, then ''ThirdPartyDesigneePhoneNum'' must have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-042-01', N'If checkbox ''PowerOfAttorneySignedByInd'' is checked in the return, then checkbox ''SurvivingSpouseInd'' must not be checked.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-043-01', N'If checkbox ''PowerOfAttorneySignedByInd'' is checked in the return, then checkbox ''PersonalRepresentativeInd'' must not be checked.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-044-01', N'If checkbox ''PowerOfAttorneySignedByInd'' is checked in the return, then ''PrimaryDeathDt'' must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-045-01', N'If checkbox ''PowerOfAttorneySignedByInd'' is checked in the return, then ''SpouseDeathDt'' must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-049-01', N'Tax returns from the U.S. Possessions of American Samoa, Guam, U.S. Virgin Islands and the Commonwealth of the Northern Mariana Islands may not be electronically filed.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-053-01', N'The ''IPAddress'' in the Return Header must not equal all zeros.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'IND-055-02', N'''AddressLine2Txt'' in the Return Header must not have a value.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-007-02', N'For US Addresses, the first five digits of ''ZipCd'' of the Filer''s address in the Return Header must be within the valid ranges of zip codes for the corresponding ''StateAbbreviationCd''. See Publication 4164.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-020-01', N'If the Filer has a US address in the Return Header and ''StateAbbreviationCd'' has the value "AA" then the first three digits of the ''ZipCd'' must be 340.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-022-01', N'If the Filer has a US address in the Return Header and ''StateAbbreviationCd'' has the value "AE" then the first three digits of the ''ZipCd'' must be in the range 090 - 098.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-024-01', N'If the Filer has a US address in the Return Header and ''StateAbbreviationCd'' has the value "AP" then first three digits of the ''ZipCd'' must be in the range 962 - 966.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-046-01', N'For US Addresses, the fourth and fifth digit of the ''ZipCd'' of the Filer''s address in the Return Header cannot both be zeros ("00"), except when the ''ZipCd'' is 00800, 20500, 34000, 00600, 96100, 96900.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-075-02', N'''RoutingTransitNum'' (RTN) must conform to the banking industry RTN algorithm.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-116-02', N'If the Filer has a US address in the Return Header and if the value of ''CityNm'' is "APO" or "DPO" or "FPO", then ''StateAbbreviationCd'' must have the value "AA", "AE" or "AP".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-117-01', N'If the Filer has a US address in the Return Header and ''StateAbbreviationCd'' has the value "AA", "AE" or "AP" then the ''CityNm'' must be "APO" OR "DPO" OR "FPO".')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-503-02', N'''SpouseSSN'' and the ''SpouseNameControlTxt'' in the Return Header (or Line 6b ''ExemptSpouseNameControlTxt'' in the return - For 1040/1040A returns) must match the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'R0000-906-02', N'Routing Transit Number (RTN) included in the return must be present in the e-File database.')
INSERT [dbo].[efile_error_message] ([efile_error_code], [efile_error_message]) VALUES (N'SCHEMA', N'Problem in Schema')



GO
INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
VALUES (N' <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Tax Garden | Congratulations!</title>
<style type=”text/css”>
html body * {
line-height:0px!important;
}
table { border-spacing:0!important;}

img {
display: block;
}

</style>
</head>
<body style="padding:0px; margin:0px">
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="22%">&nbsp;</td>
    <td width="56%" style="padding-left:5px; padding-right:5px;"><table width="650" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td style="background:#5bc0de;"><table width="650" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="152">&nbsp;</td>
                <td><img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                <td width="152">&nbsp;</td>
              </tr>
            </table></td>
        </tr>
        <tr>
          <td style="background:#5bc0de; border-bottom:solid 1px #73c9e3;border-top:solid 1px #73c9e3;"><table width="650" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="30">&nbsp;</td>
                <td width="23"><img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                <td style="font:15px Arial, Helvetica, sans-serif; color:#fff; padding:7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                <td width="175">&nbsp;</td>
                <td width="23"><img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                <td style="font:15px Arial, Helvetica, sans-serif; color:#fff; padding:7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color:#fff; text-decoration:none;">supportteam@taxgarden.com</a></td>
                <td width="30">&nbsp;</td>
              </tr>
            </table></td>
        </tr>
        <tr>
          <td height="15" style="background:#5bc0de;"></td>
        </tr>
        <tr>
          <td style="background:#5bc0de"><table width="650" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="30" style="background:#5bc0de;"><img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                <td width="590" style="background:#fff;"><img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                <td width="30" style="background:#5bc0de;"><img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
              </tr>
              <tr>
                <td style="background:#5bc0de;">&nbsp;</td>
                <td style="background:#fff;"><table width="590" border="0" cellspacing="0" cellpadding="0">

<td width="514"  style="font:12px/20px Arial, Helvetica, sans-serif; color:#737272; padding-top:10px; padding-left:10px; padding-bottom:15px;">
                       <span style="color:#ff6600; font-size:14px;"> Dear <strong>@@user_name,</strong></span><br />

                    <tr>

                      <td align="center" style="font-family:Arial, Helvetica, sans-serif; color:#5e9826; font-size:38px;"><span style="line-height:38px;">Congratulations!</span><br/>
                        <span style="font-size:13px; color:#637378;">Thanks for Signing Up with TaxGarden. You have successfully created your Account.</span></td>
                    </tr>
                    <tr>
                      <td align="center"><img src="@@Tax1040URL/Images/sep.jpg" width="569" height="30" alt="" title="" /></td>
                    </tr>
                    <tr>
                      <td align="center" style="font-size:20px; color:#ff6600; font-family:Arial, Helvetica, sans-serif; padding-bottom:10px;">Your Account Information</td>
                    </tr>
                    <tr>
                      <td><table width="590" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="38">&nbsp;</td>
                            <td width="514"><table width="512" border="0" cellspacing="0" cellpadding="0" style="border:solid 1px #ffe3d1;" align="center">
                                <tr>
                                  <td width="130" style=" padding-left:15px;background:#fffbf9; border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#737272; padding-bottom:8px; padding-top:8px;">Username</td>
                                  <td width="10" style="background:#fffbf9; border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#737272;padding-bottom:8px; padding-top:8px;">:</td>
                                  <td width="359" style="background:#fffbf9; border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#3f4446;  padding-bottom:8px; padding-top:8px;"><b>@@user_name</b></td>
                                </tr>
                                <tr>
                                  <td style="border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#737272;padding-left:15px; padding-bottom:8px; padding-top:8px;">Password</td>
                                  <td style="border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#737272;padding-bottom:8px; padding-top:8px;">:</td>
                                  <td style="border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#3f4446; padding-bottom:8px; padding-top:8px;"><b>@@password</b></td>
                                </tr>
                                <tr>
                                  <td style="background:#fffbf9; border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#737272;padding-left:15px; padding-bottom:8px; padding-top:8px;">Email ID</td>
                                  <td style="background:#fffbf9; border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#737272;padding-bottom:8px; padding-top:8px;">:</td>
                                  <td style="background:#fffbf9; border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#3f4446; padding-bottom:8px; padding-top:8px;"><b style="color:#3f4446">@@email</b></td>
                                </tr>
                                <tr>
                                  <td style="border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#737272;padding-left:15px; padding-bottom:8px; padding-top:8px;">Security Question</td>
                                  <td style="border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#737272;padding-bottom:8px; padding-top:8px;">:</td>
                                  <td style="border-bottom:solid 1px #ffe3d1; font:12px Arial, Helvetica, sans-serif; color:#3f4446; padding-bottom:8px; padding-top:8px;"><b>@@security_question</b></td>
                                </tr>
                                <tr>
                                  <td style="background:#fffbf9;font:12px Arial, Helvetica, sans-serif; color:#737272;padding-left:15px; padding-bottom:8px; padding-top:8px;">Security Answer</td>
                                  <td style="background:#fffbf9;font:12px Arial, Helvetica, sans-serif; color:#737272;padding-bottom:8px; padding-top:8px;">:</td>
                                  <td style="background:#fffbf9;font:12px Arial, Helvetica, sans-serif; color:#3f4446; padding-bottom:8px; padding-top:8px;"><b>@@security_answer</b></td>
                                </tr>
                              </table></td>
                            <td width="38">&nbsp;</td>
                          </tr>
                          <tr>
                            <td width="38">&nbsp;</td>
                            <td width="514" style="font:12px/20px Arial, Helvetica, sans-serif; color:#737272; padding-top:10px; padding-bottom:15px;">We recommend you to print this email and keep your password and security answer securely for future records.</td>
                            <td width="38">&nbsp;</td>
                          </tr>
                          <tr>
                            <td width="38">&nbsp;</td>
                            <td width="514" style="font:bold 12px/20px Arial, Helvetica, sans-serif; color:#3f4446;">Click on the below link to confirm your <a href="@@login_link" style="color:#ff6600; text-decoration:none;">Sign in</a> information.<br/>
                              </td>
                            <td width="38">&nbsp;</td>
                          </tr>
                        </table></td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                    </tr>
                  </table></td>
                <td style="background:#5bc0de;">&nbsp;</td>
              </tr>
              <tr>
                <td style="background:#5bc0de;">&nbsp;</td>
                <td style="background:#5bc0de;"><img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                <td style="background:#5bc0de;">&nbsp;</td>
              </tr>
              <tr>
                <td style="background:#5bc0de;">&nbsp;</td>
                <td style="background:#5bc0de; color:#fff; font-size:13px; font-family:Arial, Helvetica, sans-serif;" align="center"><span style="font-size:18px;">Tax Garden guaranteed your refund.</span><br/>
                  Our experts guide you to file accurate tax return and Save you a every single dollar from tax.</td>
                <td style="background:#5bc0de;">&nbsp;</td>
              </tr>
              <tr>
                <td style="background:#5bc0de;" colspan="3" height="15"></td>
              </tr>
            </table></td>
        </tr>
        <tr>
          <td style="background:#edf3f5; border-top:solid 1px #fff;"><table width="650" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td><img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                <td width="26">&nbsp;</td>
                <td width="320" valign="top"><table width="320" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td>&nbsp;</td>
                      <td>&nbsp;</td>
                    </tr>
                    <tr>
                      <td width="19"><img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                      <td style="font-size:12px; font-weight:bold; font-family:Arial, Helvetica, sans-serif; color:#3f4446; line-height:24px;"><span style="color:#5e9826;">Free</span> Federal tax Filing</td>
                    </tr>
                    <tr>
                      <td width="19"><img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                      <td style="font-size:12px; font-weight:bold; font-family:Arial, Helvetica, sans-serif; color:#3f4446; line-height:24px;"><span style="color:#5e9826;">Free</span> Unlimited advice from Tax experts</td>
                    </tr>
                    <tr>
                      <td width="19"><img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                      <td style="font-size:12px; font-weight:bold; font-family:Arial, Helvetica, sans-serif; color:#3f4446; line-height:24px;"><span style="color:#5e9826;">Free</span> Technical Support by chat or phone</td>
                    </tr>
                    <tr>
                      <td width="19"><img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                      <td style="font-size:12px; font-weight:bold; font-family:Arial, Helvetica, sans-serif; color:#3f4446;"><span style="color:#5e9826;">Free</span> Tax - Audit</td>
                    </tr>
                    <tr>
                      <td width="19"><img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                      <td style="font-size:12px; font-weight:bold; font-family:Arial, Helvetica, sans-serif; color:#3f4446;">Tracking your Return Status</td>
                    </tr>
                    <tr>
                      <td width="19"><img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                      <td style="font-size:12px; font-weight:bold; font-family:Arial, Helvetica, sans-serif; color:#3f4446;">File Your tax return any time at anywhere</td>
                    </tr>
                    <tr>
                      <td>&nbsp;</td>
                      <td>&nbsp;</td>
                    </tr>
                  </table></td>
              </tr>
            </table></td>
        </tr>
        <tr>
          <td style="border:solid 1px #edf3f5; padding:10px;"><table width="628" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td style="color:#6d6d6d; font-size:12px; font-family:Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br/>
                  <span style="color:#000000;"><strong>Support Team, Tax Garden</strong></span></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td style="font-size:11px; line-height:18px; font-family:Arial, Helvetica, sans-serif; color:#3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br/>
                  For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color:#3f4446; text-decoration:none;">supportteam@taxgarden.com</a></td>
              </tr>
            </table></td>
        </tr>
      </table></td>
    <td width="22%">&nbsp;</td>
  </tr>
</table>
</body>
</html>



 ', N'registration', 1)

GO
       
INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
              VALUES ( N'<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden | Secret Code</title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="38">&nbsp;</td>

                                                            <td align="center" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Your Secret Code!</span><br />
                                                            </td>

                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 10px; padding-bottom: 15px;">
                                                                <span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span><br />
                                                                Please find your secret code. Enter this secret code online or simply Click on the below link to reset your Password.
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>

                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">

                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Your Secret Code:</td>
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@reset_code</b></td>
                                                                    </tr>

                                                                </table>


                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>

                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">For account Security the Password reset is valid only for 24hours.<br />
                                                                <a href="@@password_reset_link">Password Reset Link</a>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>




                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: normal 12px/20px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 15px;">
                                                                <h4 style="line-height: 10px;">Protect your Account Password:</h4>
                                                                Never Share your Password, Personal Information and Email to Unknown identities, Stay away from Scammers.</td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>

                                <tr>
                                    <td style="background: #5bc0de;" colspan="3" height="15"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                                    <td width="26">&nbsp;</td>
                                    <td width="320" valign="top">
                                        <table width="320" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax experts</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: solid 1px #edf3f5; padding: 10px;">
                            <table width="628" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                                        <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                                        For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="22%">&nbsp;</td>
        </tr>
    </table>
</body>
</html>


', N'registration', 1)

GO

INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
              VALUES (N' <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden | Reset Password</title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">




                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="38">&nbsp;</td>


                                                            <td align="center" width="514" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Congratulations!</span><br />
                                                            </td>

                                                            <td width="38">&nbsp;</td>
                                                        </tr>

                                                        <td width="38">&nbsp;</td>
                                                        <td width="514">
                                                            <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                        </td>
                                                        <td width="38">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="38">&nbsp;</td>
												
                                                <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 10px;">
                                                    <span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span><br />
                                                    You have successfully Reset your Password.We are here to help you to finish your Tax return.<br />

                                                </td>
                                                <td width="38">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="38">&nbsp;</td>
                                                <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 15px; padding-bottom: 15px;">Click on the below Link to continue your session where you left off.<br />
                                                    <a href="@@login_link">TaxGarden Home page</a>



                                                </td>
                                                <td width="38">&nbsp;</td>
                                            </tr>


                                            <tr>
                                                <td width="38">&nbsp;</td>
                                                <td width="514">
                                                    <table width="512" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="164">
                                                                <table width="164" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #5e9826;" align="center">
                                                                    <tr>
                                                                        <td style="font: 12px/20px Arial, Helvetica, sans-serif; padding-bottom: 5px; border-bottom: 1px #477916 dotted; background: #f8fff4; vertical-align: top; color: #737272; padding: 5px;">
                                                                            <strong style="text-align: center; font-size: 13px; color: #477916; padding-bottom: 20px;">Free Federal Filing</strong><br />
                                                                        </td>


                                                                    </tr>

                                                                    <tr>
                                                                        <td style="font: 12px/20px Arial, Helvetica, sans-serif; background: #f8fff4; vertical-align: top; color: #737272; height: 125px; padding: 5px;">File Free your Federal Tax return and get Tax refund faster with help of our Tax	 Experts. Accurate Filing helps you to avoid IRS Notice</td>


                                                                    </tr>
                                                                </table>

                                                            </td>
                                                            <td width="7">&nbsp;</td>
                                                            <td width="164" height="152" style="vertical-align: top;">
                                                                <table width="164" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ff6600;" align="center">
                                                                    <tr>
                                                                        <td style="font: 12px/20px Arial, Helvetica, sans-serif; background: #fffbf9; padding-bottom: 5px; border-bottom: 1px #F1690E dotted; vertical-align: top; color: #737272; padding: 5px;">
                                                                            <strong style="color: #F1690E; text-align: center; font-size: 13px;">Free Tax - Audit</strong><br />
                                                                        </td>
                                                                    </tr>

                                                                    <tr>
                                                                        <td style="font: 12px/20px Arial, Helvetica, sans-serif; background: #fffbf9; height: 125px; vertical-align: top; color: #737272; padding: 5px;">Free Audit by Tax Professional. our Tax Expertise	 will represent you in	 Person and Prepare audit	 on Your Tax return.</td>
                                                                    </tr>


                                                                </table>
                                                            </td>
                                                            <td width="7">&nbsp;</td>
                                                            <td width="164" style="vertical-align: top;">
                                                                <table width="164" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #5bc0de;" align="center">
                                                                    <tr>
                                                                        <td style="font: 12px/20px Arial, Helvetica, sans-serif; background: #f9ffff; padding-bottom: 5px; border-bottom: 1px #5397AC dotted; vertical-align: top; color: #737272; padding: 5px;">
                                                                            <strong style="text-align: center; font-size: 13px; color: #5397AC;">Free Technical Support</strong><br />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="font: 12px/20px Arial, Helvetica, sans-serif; background: #f9ffff; vertical-align: top; height: 125px; color: #737272; padding: 5px;">Free Techical support by our Specialist on Chat or Phone	 for any queries with in the Tax Product</td>
                                                                    </tr>

                                                                </table>
                                                            </td>
                                                        </tr>


                                                    </table>

                                                </td>
                                                <td width="38">&nbsp;</td>
                                            </tr>




                                            <tr>
                                                <td width="38">&nbsp;</td>
                                                <td width="514">&nbsp;
                          
                                                </td>
                                                <td width="38">&nbsp;</td>
                                            </tr>

                                            <tr>
                                                <td width="38">&nbsp;</td>
                                                <td width="514">
                                                    <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                </td>
                                                <td width="38">&nbsp;</td>
                                            </tr>
                                        
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td style="background: #5bc0de;">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de;">&nbsp;</td>
                        <td style="background: #5bc0de;">
                            <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                        <td style="background: #5bc0de;">&nbsp;</td>
                    </tr>

                    <tr>
                        <td style="background: #5bc0de;" colspan="3" height="15"></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="background: #edf3f5; border-top: solid 1px #fff;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                </table>
            </td>
        </tr>

        <tr>
            <td style="background: #edf3f5; border-top: solid 1px #fff;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td>
                            <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                        <td width="26">&nbsp;</td>
                        <td width="320" valign="top">
                            <table width="320" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="19">
                                        <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                    <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                </tr>
                                <tr>
                                    <td width="19">
                                        <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                    <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax experts</td>
                                </tr>
                                <tr>
                                    <td width="19">
                                        <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                    <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                </tr>
                                <tr>
                                    <td width="19">
                                        <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                    <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                </tr>
                                <tr>
                                    <td width="19">
                                        <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                    <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                </tr>
                                <tr>
                                    <td width="19">
                                        <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                    <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="border: solid 1px #edf3f5; padding: 10px;">
                <table width="628" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                            <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                            For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </td>
    <td width="22%">&nbsp;</td>
    </tr>
</table>
</body>
</html>



', N'registration', 1)

GO

INSERT [dbo].[email_template] ( [template_Content], [template_Name], [is_active]) 
              VALUES (N'<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden | Secret Code</title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">




                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="38">&nbsp;</td>

                                                            <td align="center" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Tax Garden Username & Password Reset!</span><br />
                                                            </td>

                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>




                                                        <tr>
                                                            <td width="38">&nbsp;</td>
															
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 10px; padding-bottom: 15px;">
													
                                                                <span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span></td>
                                                            <br />
                                                        </tr>


                                                        <tr>
                                                            <td width="38">&nbsp;</td>



                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">We received request for Login Information.<br />

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>



                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; border-bottom: solid 1px #ffe3d1; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Your Username is</td>
                                                                        <td width="10" style="background: #fffbf9; border-bottom: solid 1px #ffe3d1; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td width="359" style="background: #fffbf9; border-bottom: solid 1px #ffe3d1; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@user_name</b></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-left: 15px; padding-bottom: 8px; padding-top: 8px;">Your Secret Code is</td>
                                                                        <td style="font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td style="font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@reset_code</b></td>
                                                                    </tr>

                                                                </table>

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 15px; padding-bottom: 15px;">Click on the below link to reset your Password for our website. For account Security, the Password reset is valid only for 24hours...<br />
                                                                <a href="@@password_reset_link">Password Reset Link</a>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>


                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: normal 12px/20px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 15px;">
                                                                <h4 style="line-height: 10px;">Protect your Account Information:</h4>
                                                                Never Share your Password, Personal information and Email to Unknown identities, Stay away from Scammers.</td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>

                                <tr>
                                    <td style="background: #5bc0de;" colspan="3" height="15"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                                    <td width="26">&nbsp;</td>
                                    <td width="320" valign="top">
                                        <table width="320" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax experts</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>


                    <tr>
                        <td style="border: solid 1px #edf3f5; padding: 10px;">
                            <table width="628" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                                        <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                                        For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="22%">&nbsp;</td>
        </tr>
    </table>
</body>
</html>


', N'registration', 1)

GO

INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
              VALUES ( N' <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden | Password Reset</title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">

                                                        <tr>
                                                            <td width="38">&nbsp;</td>

                                                            <td align="center" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Tax Garden Username Reset!</span><br />
                                                            </td>

                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>



                                                        <tr>
                                                            <td width="38">&nbsp;</td>
															
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">
														

                                                                <span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span><br />
                                                                We have received the request for your login.<br />

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>



                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Your Username is</td>
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@user_name</b></td>
                                                                    </tr>


                                                                </table>

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 15px; padding-bottom: 15px;">To login in to your account<br />
                                                                <a href="@@login_link">Click Here</a>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>


                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: normal 12px/20px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 15px;">
                                                                <h4 style="line-height: 10px;">Protect your Account Information:</h4>
                                                                Never Share your Password, Personal information and Email to Unknown identities, Stay away from Scammers.</td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>

                                <tr>
                                    <td style="background: #5bc0de;" colspan="3" height="15"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                                    <td width="26">&nbsp;</td>
                                    <td width="320" valign="top">
                                        <table width="320" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax experts</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: solid 1px #edf3f5; padding: 10px;">
                            <table width="628" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                                        <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                                        For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="22%">&nbsp;</td>
        </tr>
    </table>
</body>
</html>


', N'registration', 1)

GO

INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
              VALUES ( N' <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden |  Login Information</title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="38">&nbsp;</td>


                                                            <td align="center" width="514" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Update Your Email!</span><br />
                                                            </td>

                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
															
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">
															
                                                                <span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span><br />
																
                                                                You have Sucessfuly updated your Email  Address.<br />

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>



                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Your Email Address</td>
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@email</b></td>
                                                                    </tr>


                                                                </table>

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 15px; padding-bottom: 15px;">Click on the below Link to continue your session where you left off.<br />
                                                                <a href="@@login_link">TaxGarden Home page</a>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: normal 12px/20px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 15px;">
                                                                <h4 style="line-height: 10px;">Protect your Account Information:</h4>
                                                                Never Share your Password, Personal information and Email to Unknown identities, Stay away from Scammers.</td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>

                                <tr>
                                    <td style="background: #5bc0de;" colspan="3" height="15"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                                    <td width="26">&nbsp;</td>
                                    <td width="320" valign="top">
                                        <table width="320" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax experts</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: solid 1px #edf3f5; padding: 10px;">
                            <table width="628" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                                        <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                                        For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="22%">&nbsp;</td>
        </tr>
    </table>
</body>
</html>
', N'registration', 1)


/*03Jun2014 Sathish EFile email content */
INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
              VALUES ( N'<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden</title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td align="center" width="514" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Federal Transmission!</span><br />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;"><span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span><br />

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Thanks for E-filing your Federal return with ''Tax Garden''</td>

                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 15px; padding-bottom: 15px;">The  IRS will process your return within 24-48 hours. We will email you  a status update when<br />
                                                                IRS processing is complete.</td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 15px; padding-bottom: 15px;">Once you receive your Status Update,  Sign In to Tax Garden account to check the status<br />
                                                                of your return</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;" colspan="3" height="15"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0"></table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                                    <td width="26">&nbsp;</td>
                                    <td width="320" valign="top">
                                        <table width="320" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax exports</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: solid 1px #edf3f5; padding: 10px;">
                            <table width="628" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                                        <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                                        For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="22%">&nbsp;</td>
        </tr>
    </table>
</body>
</html>', N'E-File', 1)


INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
              VALUES ( N' <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden </title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td align="center" width="514" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Federal Acceptance!</span><br />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;"><span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span><br />

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Congratulation, Your Federal return was sucessfully accepted by IRS</td>

                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 15px; padding-bottom: 15px;">You can also check your acceptance status by Sign In to Tax Garden.
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;" colspan="3" height="15"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0"></table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                                    <td width="26">&nbsp;</td>
                                    <td width="320" valign="top">
                                        <table width="320" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax exports</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: solid 1px #edf3f5; padding: 10px;">
                            <table width="628" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                                        <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                                        For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="22%">&nbsp;</td>
        </tr>
    </table>
</body>
</html>', N'E-File', 1)

INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
              VALUES ( N'<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden </title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td align="center" width="514" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Federal Rejection!</span><br />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;"><span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span><br />

                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Thanks for filing your Federal tax return with  Tax Garden. Your Federal return was rejected by IRS.</td>
                                                                    </tr>

                                                                </table>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>


                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; text-align: center; color: #737272; padding-top: 15px; padding-bottom: 15px;">To know reason for rejection, Click on below link
                                                                <br />
                                                                <a href="mailto:Federal Rejection Messages" style="color: #ff0900; text-align: center; margin: 8px 0 0; font-family: arial; font-size: 18px; line-height: 25px; display: block;">Federal Rejection Messages</a>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>

                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 15px; padding-bottom: 15px;">Kindly fix the errors that IRS detected on  your Tax return and resubmit your  Federal Return.</td>
                                                        </tr>

                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;" colspan="3" height="15"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0"></table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                                    <td width="26">&nbsp;</td>
                                    <td width="320" valign="top">
                                        <table width="320" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax exports</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: solid 1px #edf3f5; padding: 10px;">
                            <table width="628" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                                        <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                                        For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="22%">&nbsp;</td>
        </tr>
    </table>
</body>
</html>
', N'E-File', 1)









INSERT [dbo].[email_template] ([template_Content], [template_Name], [is_active]) 
              VALUES ( N'<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tax Garden | Invoice</title>
    <style type="”text/css”">
        html body * {
            line-height: 0px!important;
        }

        table {
            border-spacing: 0!important;
        }

        img {
            display: block;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td width="22%">&nbsp;</td>
            <td width="56%" style="padding-left: 5px; padding-right: 5px;">
                <table width="650" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="background: #5bc0de;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="152">&nbsp;</td>
                                    <td>
                                        <img src="@@Tax1040URL/Images/logo.jpg" width="346" height="107" alt="Tax Garden" title="Tax Garden" /></td>
                                    <td width="152">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de; border-bottom: solid 1px #73c9e3; border-top: solid 1px #73c9e3;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/phone.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;">Toll Free<strong> 1-866-245-3918</strong></td>
                                    <td width="175">&nbsp;</td>
                                    <td width="23">
                                        <img src="@@Tax1040URL/Images/mail.jpg" width="23" height="35" alt="" title="" /></td>
                                    <td style="font: 15px Arial, Helvetica, sans-serif; color: #fff; padding: 7px 0px;"><a href="mailto:supportteam@taxgarden.com" style="color: #fff; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                    <td width="30">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="15" style="background: #5bc0de;"></td>
                    </tr>
                    <tr>
                        <td style="background: #5bc0de">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/left.jpg" width="30" height="27" alt="" title="" /></td>
                                    <td width="590" style="background: #fff;">
                                        <img src="@@Tax1040URL/Images/center.jpg" width="590" height="27" alt="" title="" /></td>
                                    <td width="30" style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/right.jpg" width="30" height="27" alt="" title="" /></td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #fff;">
                                        <table width="590" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>
                                                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td align="center" style="font-family: Arial, Helvetica, sans-serif; color: #ff6600; padding-bottom: 10px; font-size: 28px;"><span style="line-height: 38px;">Invoice for Payment with Tax Garden!</span><br />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-top: 10px; padding-bottom: 15px;"><span style="color: #ff6600; font-size: 14px;">Dear <strong>@@user_name,</strong></span><br />
                                                                Transaction Details </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Invoice Number:</td>
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@invoicenumber</b></td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">Your  Card will be billed as <a href="www.TaxGarden.com">www.TaxGarden.com</a>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">You will receive  a confirmation email on the Payment Invoice. 
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">Click to Print Your Receipt &nbsp;&nbsp;&nbsp;&nbsp;
                                                            <img src="@@Tax1040URL/Images/print.jpg" alt="" title="" /></td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Name:</td>
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@name</b></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Date:</td>
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@date</b></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Address:</td>
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">:</td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@address</b></td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514" style="font: 12px/20px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 15px;">
                                                                <table width="512" border="0" cellspacing="0" cellpadding="0" style="border: solid 1px #ffe3d1;" align="center">
                                                                    <tr>
                                                                        <td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Service</td>
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;"></td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>Price</b></td>
                                                                    </tr>

                                                                    <tr>
                                                                        <!--<td width="130" style="padding-left: 15px; background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;">Date:</td>-->
                                                                        <td width="10" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #737272; padding-bottom: 8px; padding-top: 8px;"></td>
                                                                        <td width="359" style="background: #fffbf9; font: 12px Arial, Helvetica, sans-serif; color: #3f4446; padding-bottom: 8px; padding-top: 8px;"><b>@@statecharges</b></td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="38">&nbsp;</td>
                                                            <td width="514">
                                                                <img src="@@Tax1040URL/Images/sep.jpg" width="514" alt="" title="" />
                                                            </td>
                                                            <td width="38">&nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                    <td style="background: #5bc0de;">
                                        <img src="@@Tax1040URL/Images/bottom.jpg" width="590" height="34" alt="" title="" /></td>
                                    <td style="background: #5bc0de;">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="background: #5bc0de;" colspan="3" height="15"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0"></table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background: #edf3f5; border-top: solid 1px #fff;">
                            <table width="650" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="@@Tax1040URL/Images/onlyin.jpg" width="304" height="191" alt="Only In Tax Garden" title="Only In Tax Garden" /></td>
                                    <td width="26">&nbsp;</td>
                                    <td width="320" valign="top">
                                        <table width="320" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Federal tax Filing</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Unlimited advice from Tax experts</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446; line-height: 24px;"><span style="color: #5e9826;">Free</span> Technical Support by chat or phone</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;"><span style="color: #5e9826;">Free</span> Tax - Audit</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">Tracking your Return Status</td>
                                            </tr>
                                            <tr>
                                                <td width="19">
                                                    <img src="@@Tax1040URL/Images/bullet.jpg" width="19" height="24" alt="" title="" /></td>
                                                <td style="font-size: 12px; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">File Your tax return any time at anywhere</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: solid 1px #edf3f5; padding: 10px;">
                            <table width="628" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td style="color: #6d6d6d; font-size: 12px; font-family: Arial, Helvetica, sans-serif;">Thanks &amp; Regards,<br />
                                        <span style="color: #000000;"><strong>Support Team, Tax Garden</strong></span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 11px; line-height: 18px; font-family: Arial, Helvetica, sans-serif; color: #3f4446;">This is an automatically generated Email, Please do not reply to this Email.<br />
                                        For any queries &amp; assistance related to Tax Garden, Kindly contact us as <a href="mailto:supportteam@taxgarden.com" style="color: #3f4446; text-decoration: none;">supportteam@taxgarden.com</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="22%">&nbsp;</td>
        </tr>
    </table>
</body>
</html>

', N'E-File', 1)


GO

/* 16Apr2014 Sathish.N added static data for state_zip_code_conditions will have condition associated to each state */
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (1, N'((tempZipCode >= 35000)  AND  (tempZipCode <= 36999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (2, N'((tempZipCode >= 99500)  AND  (tempZipCode <= 99999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (3, N'((tempZipCode >= 85000)  AND  (tempZipCode <= 86599))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (4, N'(((tempZipCode >= 71600)  AND  (tempZipCode <= 72999))  OR  (tempZipCode = 75502))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (5, N'(((tempZipCode >= 90000)  AND  (tempZipCode <= 90899))  OR  ((tempZipCode >= 91000)  AND  (tempZipCode <= 96199)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (6, N'((tempZipCode >= 80000)  AND  (tempZipCode <= 81699))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (7, N'((tempZipCode >= 6000)  AND  (tempZipCode <= 6999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (8, N'((tempZipCode >= 19700)  AND  (tempZipCode <= 19999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (9, N'((tempZipCode >= 20000)  AND  (tempZipCode <= 20599))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (10, N'(((tempZipCode >= 32000)  AND  (tempZipCode <= 33999))  OR  ((tempZipCode >= 34100)  AND  (tempZipCode <= 34199))  OR  ((tempZipCode >= 34200)  AND  (tempZipCode <= 34299))  OR  ((tempZipCode >= 34400)  AND  (tempZipCode <= 34499))  OR  ((tempZipCode >= 34600)  AND  (tempZipCode <= 34699))  OR  ((tempZipCode >= 34700)  AND  (tempZipCode <= 34799))  OR  ((tempZipCode >= 34900)  AND  (tempZipCode <= 34999)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (11, N'(((tempZipCode >= 30000)  AND  (tempZipCode <= 31999))  OR  (tempZipCode = 39815)  OR  (tempZipCode = 39834)  OR (tempZipCode=39837) OR  ((tempZipCode >= 39900)  AND  (tempZipCode <= 39999)) OR  (tempZipCode = 39897))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (12, N'(((tempZipCode >= 96700)  AND  (tempZipCode <= 96799))  OR  ((tempZipCode >= 96800)  AND  (tempZipCode <= 96899)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (13, N'((tempZipCode >= 83200)  AND  (tempZipCode <= 83899))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (14, N'((tempZipCode >= 60000)  AND  (tempZipCode <= 62999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (15, N'((tempZipCode >= 46000)  AND  (tempZipCode <= 47999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (16, N'((tempZipCode >= 50000)  AND  (tempZipCode <= 52899))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (17, N'((tempZipCode >= 66000)  AND  (tempZipCode <= 67999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (18, N'(((tempZipCode >= 40000)  AND  (tempZipCode <= 42799))  OR  (tempZipCode = 45275))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (19, N'(((tempZipCode >= 70000)  AND  (tempZipCode <= 71499))  OR  (tempZipCode = 71749))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (20, N'(((tempZipCode >= 3900)  AND  (tempZipCode <= 4999))  OR  (tempZipCode = 3801))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (21, N'(((tempZipCode >= 20600)  AND  (tempZipCode <= 21999))  OR  (tempZipCode = 20331))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (22, N'(((tempZipCode >= 1000)  AND  (tempZipCode <= 2799))  OR  ((tempZipCode >= 5500)  AND  (tempZipCode <= 5599)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (23, N'((tempZipCode >= 48000)  AND  (tempZipCode <= 49999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (24, N'((tempZipCode >= 55000)  AND  (tempZipCode <= 56799))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (25, N'((tempZipCode >= 38600)  AND  (tempZipCode <= 39799))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (26, N'((tempZipCode >= 63000)  AND  (tempZipCode <= 65899))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (27, N'((tempZipCode >= 59000)  AND  (tempZipCode <= 59999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (28, N'((tempZipCode >= 68000)  AND  (tempZipCode <= 69399))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (29, N'((tempZipCode >= 88900)  AND  (tempZipCode <= 89899))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (30, N'((tempZipCode >= 3000)  AND  (tempZipCode <= 3899))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (31, N'((tempZipCode >= 7000)  AND  (tempZipCode <= 8999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (32, N'((tempZipCode >= 87000)  AND  (tempZipCode <= 88499))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (33, N'(((tempZipCode >= 400)  AND  (tempZipCode <= 499))  OR  ((tempZipCode >= 500)  AND  (tempZipCode <= 599))  OR  (tempZipCode = 6390)  OR  ((tempZipCode >= 10000)  AND  (tempZipCode <= 14999)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (34, N'((tempZipCode >= 27000)  AND  (tempZipCode <= 28999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (35, N'((tempZipCode >= 58000)  AND  (tempZipCode <= 58899))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (36, N'((tempZipCode >= 43000)  AND  (tempZipCode <= 45999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (37, N'(((tempZipCode >= 73000)  AND  (tempZipCode <= 73299))  OR  ((tempZipCode >= 73400)  AND  (tempZipCode <= 74999)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (38, N'((tempZipCode >= 97000)  AND  (tempZipCode <= 97999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (39, N'((tempZipCode >= 15000)  AND  (tempZipCode <= 19699))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (40, N'(((tempZipCode >= 2800)  AND  (tempZipCode <= 2899))  OR  ((tempZipCode >= 2900)  AND  (tempZipCode <= 2999)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (41, N'((tempZipCode >= 29000)  AND  (tempZipCode <= 29999))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (42, N'((tempZipCode >= 57000)  AND  (tempZipCode <= 57799))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (43, N'((tempZipCode >= 37000)  AND  (tempZipCode <= 38599))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (44, N'(((tempZipCode >= 75000)  AND  (tempZipCode <= 79999))  OR  ((tempZipCode >= 73300)  AND  (tempZipCode <= 73399))  OR  (tempZipCode = 73949))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (45, N'((tempZipCode >= 84000)  AND  (tempZipCode <= 84799))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (46, N'(((tempZipCode >= 5000)  AND  (tempZipCode <= 5499))  OR  ((tempZipCode >= 5600)  AND  (tempZipCode <= 5999)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (47, N'(((tempZipCode >= 22000)  AND  (tempZipCode <= 24699))  OR  ((tempZipCode >= 20100)  AND  (tempZipCode <= 20199))  OR  (tempZipCode = 20041)  OR  (tempZipCode = 20301)  OR  (tempZipCode = 20370))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (48, N'(((tempZipCode >= 98000)  AND  (tempZipCode <= 98699))  OR  ((tempZipCode >= 98800)  AND  (tempZipCode <= 99499)))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (49, N'((tempZipCode >= 24700)  AND  (tempZipCode <= 26899))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (50, N'(((tempZipCode >= 53000)  AND  (tempZipCode <= 54999))  OR  (tempZipCode = 49936))')
INSERT [dbo].[state_zip_code_conditions] ([state_id], [condition]) VALUES (51, N'((tempZipCode >= 82000)  AND  (tempZipCode <= 83199))')
