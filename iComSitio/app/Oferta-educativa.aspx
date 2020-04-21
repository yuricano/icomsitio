<%@ Page Title="" Language="C#" MasterPageFile="~/Sitio.master" AutoEventWireup="true"
    CodeFile="Oferta-educativa.aspx.cs" Inherits="_Oferta" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="oferta" class=" fondo-oscuro padding">
        <h3 class="texto-blanco center">OFERTA EDUCATIVA</h3>

        <p class="texto-blanco center">
            Nuestra modalidad virtual promueve la formación profesional, hace que sea
								accesible para cualquier persona, ya que desde su oficina, su hogar, otra ciudad o incluso otro país podrá
								acceder a nuestra plataforma, estudiar las unidades y adjuntar sus tareas.
        </p>

        <p class="texto-blanco center">
            Además, ofrecemos un plan de estudios diseñado para el desarrollo de las
								competencias profesionales que requiere el mercado laboral, en nueve tetramestres podrás adquirir los
								conocimientos teórico-prácticos utilizando lo último en tecnología educativa, contando siempre con los mejores
								Maestros y atención personalizada.
        </p>

        <div class="grid-x grid-padding-x">
            <div class="large-4 medium-4 cell">
                <a href="oferta-educativa-lcdm.aspx">
                    <div class="callout">
                        <img src="../assets/img/oferta-lcmd.png">
                        <h3>LCMD</h3>
                        <p class="texto-morado">
                            LICENCIATURA EN COMUNICACIÓN Y MEDIOS DIGIALES
                    </div>
                </a>
            </div>
            <div class="large-4 medium-4 cell">
                <a href="oferta-educativa-lme.aspx">
                    <div class="callout">
                        <img src="../assets/img/oferta-lmd.png">
                        <h3>LME</h3>
                        <p class="texto-morado">LICENCIATURA EN MERCADOTECNIA ESTRATÉGICA</p>
                    </div>
                </a>
            </div>
            <div class="large-4 medium-4 cell">
                <a href="oferta-educativa-mcmd.aspx">
                    <div class="callout">
                        <img src="../assets/img/oferta-mcmd.png">
                        <h3>MCMD</h3>
                        <p class="texto-morado">MAESTRÍA EN COMUNICACIÓN Y MERCADOTECNIA DEPORTIVA </p>
                    </div>
                </a>
            </div>
        </div>
    </div>

</asp:Content>
