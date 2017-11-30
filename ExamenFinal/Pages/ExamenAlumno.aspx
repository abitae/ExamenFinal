<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="ExamenAlumno.aspx.cs" Inherits="ExamenFinal.Pages.ExamenAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Examen </title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <ul class="nav nav-tabs">
  <li class="active"><a data-toggle="tab" href="#home">Instrucciones</a></li>
  <li><a data-toggle="tab" href="#menu1">Pregunta 1</a></li>
  <li><a data-toggle="tab" href="#menu2">Pregunta 2</a></li>
  <li><a data-toggle="tab" href="#menu3">Pregunta 3</a></li>
  <li><a data-toggle="tab" href="#menu4">Pregunta 4</a></li>
  <li><a data-toggle="tab" href="#menu5">Pregunta 5</a></li>
  <li><a data-toggle="tab" href="#menu6">Pregunta 6</a></li>
  <li><a data-toggle="tab" href="#menu7">Pregunta 7</a></li>
  <li><a data-toggle="tab" href="#menu8">Pregunta 8</a></li>
  <li><a data-toggle="tab" href="#menu9">Pregunta 9</a></li>
  <li><a data-toggle="tab" href="#menu10">Pregunta 10</a></li>
  <li><a data-toggle="tab" href="#finalizar">Finalizar</a></li>
</ul>

<div class="tab-content">
  <div id="home" class="tab-pane fade in active">
    <h3>Instrcuciones</h3>
    <p>Lee y responde cada una de las preguntas.</p>
     
  </div>
  <div id="menu1" class="tab-pane fade">
        <div class="container">
        <div class="jumbotron">
          <h3>
            <asp:Label ID="preg1" runat="server" Text="Label"></asp:Label>

         </h3>
  
          <asp:RadioButton id="rp11" GroupName="pre1"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp12" GroupName="pre1"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp13" GroupName="pre1"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp14" GroupName="pre1"
               runat="server"/>
         </div>
        </div>
  </div>
  <div id="menu2" class="tab-pane fade">
      <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg2" runat="server" Text="Label"></asp:Label>

    </h3>
          
           <asp:RadioButton id="rp21" GroupName="pre2"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp22" GroupName="pre2"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp23" GroupName="pre2"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp24" GroupName="pre2"
               runat="server"/>
           </div>
        </div>
        
  </div>
     <div id="menu3" class="tab-pane fade">
         <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg3" runat="server" Text="Label"></asp:Label>

    </h3>
          
           <asp:RadioButton id="rp31" GroupName="pre3"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp32" GroupName="pre3"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp33" GroupName="pre3"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp34" GroupName="pre3"
               runat="server"/>
            </div>
             </div>
  </div>
     <div id="menu4" class="tab-pane fade">
          <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg4" runat="server" Text="Label"></asp:Label>

    </h3>
          
           <asp:RadioButton id="rp41" GroupName="pre4"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp42" GroupName="pre4"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp43" GroupName="pre4"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp44" GroupName="pre4"
               runat="server"/>
            </div>
             </div>
           
  </div>
     <div id="menu5" class="tab-pane fade">
          <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg5" runat="server" Text="Label"></asp:Label>

    </h3>
           
           <asp:RadioButton id="rp51" GroupName="pre5"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp52" GroupName="pre5"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp53" GroupName="pre5"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp54" GroupName="pre5"
               runat="server"/>
            </div>
            </div>
  </div>
     <div id="menu6" class="tab-pane fade">
          <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg6" runat="server" Text="Label"></asp:Label>

    </h3>
             
           <asp:RadioButton id="rp61" GroupName="pre6"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp62" GroupName="pre6"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp63" GroupName="pre6"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp64" GroupName="pre6"
               runat="server"/>
            </div>
              </div>
  </div>
     <div id="menu7" class="tab-pane fade">
         <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg7" runat="server" Text="Label"></asp:Label>

    </h3>
             
           <asp:RadioButton id="rp71" GroupName="pre7"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp72" GroupName="pre7"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp73" GroupName="pre7"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp74" GroupName="pre7"
               runat="server"/>
            </div>
             </div>
  </div>
     <div id="menu8" class="tab-pane fade">
            <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg8" runat="server" Text="preg8"></asp:Label>

    </h3>
              
           <asp:RadioButton id="rp81" GroupName="pre8"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp82" GroupName="pre8"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp83" GroupName="pre8"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp84" GroupName="pre8"
               runat="server"/>
            </div>
                </div>
  </div>

     <div id="menu9" class="tab-pane fade">
            <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg9" runat="server" Text="Label"></asp:Label>

    </h3>
    
             
           <asp:RadioButton id="rp91" GroupName="pre9"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp92" GroupName="pre9"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp93" GroupName="pre9"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp94" GroupName="pre9"
               runat="server"/>
            </div>
                </div>
    </div>

    <div id="menu10" class="tab-pane fade">
         <div class="container">
        <div class="jumbotron">
    <h3><asp:Label ID="preg10" runat="server" Text="preg10"></asp:Label>

    </h3>
             
           <asp:RadioButton id="rp101" GroupName="pre10"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp102" GroupName="pre10"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp103" GroupName="pre10"
               runat="server"/>
              <br />
          <asp:RadioButton id="rp104" GroupName="pre10"
               runat="server"/>
            </div>
             </div>
  </div>
     <div id="finalizar" class="tab-pane fade">
          <div class="container">
        <div class="jumbotron">
    <h3>Finalizar Examen</h3>
            <asp:Button ID="BtnFinalizar" OnClick="BtnFinalizar_Click" runat="server" Text="Button" />
    </div></div>
  </div>
</div>
    <div>
   
        <h2  >
    <asp:Label ID="Info" runat="server" Text="" class="label label-warning" ></asp:Label>
            </h2>
   
        </div>
</asp:Content>
