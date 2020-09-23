
Module TemplateHtml
    Public Function getHtml() As String

        'Creo la variable HTML como string para ser devuelta
        Dim htmlBody As String = "<!DOCTYPE html>" &
                "<html>" &
                    "<head>" &
                        "<meta charset='utf-8'/>" &
                        "<title></title>" &
                        "<style>" &
                        "table {" &
                            "border:   1px solid black;" &
                            "padding: 5px;" &
                        "}" &
                    "</style>" &
                    "</head>" &
                    "<body>" &
                        "<table style='width:50%' align='center'>" &
                            "<tr>" &
                                "<td align='left'>" &
                                    "<p style='font-size: 32px;'>Buenas tardes, <b> Dr. Andrés Salas Jimenez, PhD </b></br>" &
                            "</td>" &
                                "<th>" &
                                "</th>" &
                            "</tr>" &
                            "<tr>" &
                                "<td><p style='font-size: 32px;'>Es un gusto mostrarle una imagen de un lugar donde usted puede ir junto con nosotros si visita Costa Rica.</p></td>" &
                            "</tr>" &
                            "<tr>" &
                                "<td align='center'>" &
                                    "<h1><b>Vista del Destino <br><br> TROPICAL </b></h1>" &
                                "</td>" &
                            "</tr>" &
                            "<tr>" &
                                "<td align='center'>" &
                                    "<img src='cid:imagen' style='width:80%;max-width:4500px;'/>" &
                                "</td>" &
                            "</tr>" &
                            "<tr>" &
                                "<td align='right'>" &
                                    "<p style='font-size: 25px;'>" &
                                    "Cordialmente," &
                                    "<br><b> Lic. Lizandro Castalleda Arkemita </b>" &
                                            "<br><small style='font-size: 20px;'><em>Secretario General de Turismo</em></small>" &
                                                "<br><b style='font-size:18px'> Costa Rica</b>" &
                            "</td>" &
                    "</table>" &
                    "</body>" &
                "</html>"

        Return htmlBody

    End Function
End Module