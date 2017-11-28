<%@ Page Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="MatriculaAlumno.aspx.cs" Inherits="ExamenFinal.Pages.MatriculaAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <h1> Mis Examenes &nbsp;&nbsp;&nbsp; </h1>
      
            <asp:GridView ID="grd_misexamenes" runat="server" DataKeyNames="CodiExamen"  AutoGenerateColumns="False" OnSelectedIndexChanged="grd_misexamenes_SelectedIndexChanged">
                
                <Columns>
                    <asp:BoundField DataField="CodMatricula" HeaderText="Codigo Matricula"  Visible="false" />
                    <asp:BoundField DataField="CodiExamen" HeaderText="Codigo Examenes" />
                    <asp:BoundField DataField="Nota" HeaderText="Nota" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>

        </asp:GridView>
    
           
       
     

</asp:Content>
