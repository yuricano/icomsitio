<%@ Page Title="" Language="C#" MasterPageFile="~/Sitio.master" AutoEventWireup="true"
    CodeFile="Admision.aspx.cs" Inherits="_Admision" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class=" fondo-oscuro padding">
        <h3 class="texto-blanco center padding20">ADMISIÓN</h3>

        <div id="admision" class="fondo-oscuro padding">
            <div class="grid-x grid-padding-x">
                <div class="large-6 medium-4 small-12 cell">

                    <div class="callout large">
                        <h3 class="texto-morado">Licenciatura</h3>
                        <ul>
                            <li>Escanear el original y por ambos lados el certificado de Secundaria</li>
                            <li>Escanear el original y por ambos lados el certificado de Preparatoria</li>
                            <li>Escanear el acta de nacimiento</li>
                            <li>Escanear por ambos lados una identificación oficial</li>
                            <li>Clave Única de Registro de Población (CURP)</li>
                            <li>Dos fotografías</li>
                            <li>Llenar solicitud de Licenciatura (página web)</li>
                        </ul>
                        <a href="solicitud-en-linea.aspx#solicitud" class="button">INSCRÍBETE AHORA</a>
                    </div>
                </div>
                <div class="large-6 medium-6 small-12 cell">
                    <div class="callout large">
                        <h3 class="texto-morado">Maestría</h3>
                        <ul>
                            <li>Escanear el original y por ambos lados el título o carta pasante del nivel licenciatura
                            </li>
                            <li>Escanear el original y por ambos lados la Cédula Profesional</li>
                            <li>Dos fotografías</li>
                            <li>Escanear el acta de nacimiento</li>
                            <li>Escanear por ambos lados una identificación oficial</li>
                            <li>Clave Única de Registro de Población (CURP)</li>
                            <li>Llenar solicitud de posgrado (página web)</li>
                            <li>Cumplir con el perfil de ingreso</li>
                        </ul>
                        <a href="solicitud-en-linea.aspx#solicitud" class="button">INSCRÍBETE AHORA</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
