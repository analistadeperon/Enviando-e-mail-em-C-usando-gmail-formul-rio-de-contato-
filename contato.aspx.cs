using System.Net.Mail;

protected void btnSend_Click(object sender, EventArgs e)
{
	string sUserName = "email@gmail.com"; //Login
	string sPassword = "senha"; //Senha
	string sBody = "Mensagem:\n\n" +
					 "Nome: " + txtName.Text + "\n" +
					 "email: " + txtEmail.Text + "\n" +
					 "Mensagem: " + txtMessage.Text + "\n\n";

	MailMessage objEmail = new MailMessage();
	objEmail.To.Add(sUserName);
	objEmail.From = new MailAddress(txtEmail.Text.Trim());
	objEmail.Subject = "Título da mensagem";
	objEmail.Body = sBody;

	SmtpClient smtp = new SmtpClient();
	smtp.Host = "smtp.gmail.com"; //Servidor 
	smtp.Credentials = new System.Net.NetworkCredential(sUserName, sPassword);
	smtp.EnableSsl = true;
	smtp.Send(objEmail);

	//Redireciona para a página que mostra a mensagem: "e-mail foi enviado".
	Response.Redirect(Request.Url.AbsolutePath + "?acao=enviado");
} 
