<div>
	<table>
		<tr>
			<td>
				Nome:
			</td>
			<td>
				<asp:TextBox ID="txtName" runat="server" />
			</td>
		</tr>
		<tr>
			<td>
				e-mail:
			</td>
			<td>
				<asp:TextBox ID="txtEmail" runat="server" />
			</td>
		</tr>
		<tr>
			<td colspan="2">
				Mensagem:<br />
				<asp:TextBox ID="txtMessage" runat="server" 
				TextMode="MultiLine" Height="180px" />
			</td>
		</tr>
	</table>
</div>
<div>
	<asp:Button ID="btnSend" runat="server" 
	Text="Enviar" onclick="btnSend_Click" />
</div>
