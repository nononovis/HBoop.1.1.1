<%
  '----------- Paramètres Email Site  --------------------------------
  
  emailSiteSeDesign = "mariem.tebai@gmail.com"
  emailSiteSeDesignTo = "mariem.tebai@gmail.com"
  SeDesignFromName = "Salon de coiffure Nouveau Contact Site Web "
  
   Dim objCDOSYSMail
  '-------------------------------------------------------------------------
  
  Public Function createMailObject()
     Dim objCDOSYSCon
  
     Set objCDOSYSMail = Server.CreateObject("CDO.Message")
     Set objCDOSYSCon = Server.CreateObject ("CDO.Configuration")
	 Set objBodyPart = objCDOSYSMail.BodyPart 
         objBodyPart.Charset = "UTF-8" 	    	
     With objCDOSYSCon
		        	.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "smtp.gnet.tn"
		        	.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserverport")  = 25
		        	.Fields("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
		        	.Fields("http://schemas.microsoft.com/cdo/configuration/smtpconnectiontimeout") = 21600
		        	.Fields.Update 
     End With
     Set objCDOSYSMail.Configuration = objCDOSYSCon
  End Function
  
  '-------------------------------------------------------------------------
  
  Public Function dropMailObject()
     Set Mailer = Nothing
  End Function
  
  '-------------------------------------------------------------------------
  
  Public Function SendMail(ByVal EmailMembers,ByVal EmailSubject,ByVal EmailContent)
    
    With objCDOSYSMail	
				
				.From = "WebSiteServerContact@smiri.com.tn"
				.To = EmailMembers
				.Subject = EmailSubject
				.HTMLBody = EmailContent
				.Send
	End with	
  End Function
  
  '-------------------------------------------------------------------------
  
  nom=request.Form("nom")
  nom=replace(nom,"'","''")
    
  email=request.Form("email")
  email=replace(email,"'","''")
  
  SecondName=request.Form("secondname")
  SecondName=replace(SecondName,"'","''")
  
  message=request.Form("message")
  message=replace(message,"'","''")
  
  If ((SecondName = Null) or (SecondName = "")) Then
  EmailContent = "<b>Date d'envoi: </b> "&Now()&"<br/><br/><b>Nom:</b> "&nom&"<br/><br/><b>E-mail:</b> "&email&"<br/><br/><p><b>Message:</b><br/>"&message&"</p>"
  
  EmailSubject = "Nouveau Contact Site Web Salon de coiffure : "&Now()
  Call createMailObject()
  On Error Resume Next
  Call SendMail(emailSiteSeDesignTo,EmailSubject,EmailContent)
  On Error goto 0
  Call dropMailObject()
  
  response.Write("answer=ok")
    End If
%>
