# SomeProjects-CSHARP


this project is quality assesment project in an automaker company. there are some working stations in a car factory in each department (like Assembply, Manufacture, Paint & ...)
first you need to define workstations (aka EWT) and assign them to one of those aformentioned departments. the system automatically selects a name for each station.

the next step is to define a Mr.responsible, an auditor and a checkman for each station and make an account for them in the application. each Mr.responsible can only handle 1 
station. but checkman and auditor can be assigned to multiple stations. there is also a section in  the application called "Fails" in which the name and the reason for all 
matters that lead to a fai in stations can be defined.

in the next step, each Mr.responsible input some dily data like 
<ul><b>accidents</b></ul>
<ul><b>reworks</b></ul>
<ul><b>wastes</b></ul>
<ul><b>NP: the number and type of malfunctioning car parts receieved from the previous station</b></ul>   
<ul>ps: it's possible for Mr.Responsible to direct the malfunction to a specific department</ul>
<ul><b>NR: the number and type of malfunctioning car parts made in his own station(and their reasons)</b></ul>
<ul><b>production line stop</b></ul>
<ul><b>number of productions</b></ul>
<ul><b>the score of 5s</b></ul>
<ul><b>workers recommendations</b></ul>
<ul><b>the score of 5s</b></ul>
<ul> NQa = Quality assesment for Auditor </ul>
<ul> NQc = Quality assesment for CheckMan </ul>


each Mr.Responsible can only input the information (marked with bold) related to the last 2 working days in the company.


Checkman And Auditor check the line and insert some problems with their number of occurance in the application and enter the quality-check data. User Access to different Forms
and UserControld are defined by Roles. So each user has access to his own forms.

there is also dynamic search and a well-structured data picker exclusively developed for this program that are used in many forms.

in the end, there are some reports made with stimulsoft available for different roles and a Power BI dashboard embedded in the application.

ps:

<b>For Security The password has been removed from the project</b>
