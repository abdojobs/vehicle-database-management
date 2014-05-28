<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <html>
    <meta http-equiv="content-Type" content="text/html; charset=UTF-8" />
    <body style="background-color:#B2E0FF">
      <center><h1>Felhasználók</h1></center>
      <xsl:for-each select="//Csoport">
        <h2><u>
            <xsl:value-of select="@CsoportNev"/> csoportba tartozó felhasználók
        </u></h2>
        <table width="30%" border="1" style="border-collapse:collapse;margin-top:-20px;margin-left:15px;background-color:#F4F4F4;font-size:18px">
          <tr style="background-color:#87B2F3">
            <th width ="30%">Sorszám</th>
            <th width ="70%">Felhasználónév</th>
          </tr>
          <xsl:for-each select="./Felhasznalo">
            <tr>
              <td><xsl:value-of select="FelhasznaloID"/></td>
              <td><xsl:value-of select="FelhasznaloNev"/></td>
            </tr>
          </xsl:for-each>
        </table>
      </xsl:for-each>
    </body>
    </html>
    </xsl:template>
  
</xsl:stylesheet>
