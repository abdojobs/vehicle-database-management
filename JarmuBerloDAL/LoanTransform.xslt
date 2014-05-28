<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="xml" indent="yes"/>
  
  <xsl:template match="/">
    <html>
    <meta http-equiv="content-Type" content="text/html; charset=UTF-8" />
    <body style="background-color:#B2E0FF">
      <center><h1>Bérlések</h1></center>
      <xsl:for-each select="//Berlo">
        <h2><u>
            <xsl:value-of select="@BerloNev"/> (tel. szám:<xsl:value-of select="@Telefonszam"/>, jogosítványszám:<xsl:value-of select="@Jogositvanyszam"/>) bérlései
        </u></h2>
        <table width="50%" border="1" style="border-collapse:collapse;margin-top:-20px;margin-left:15px;background-color:#F4F4F4;font-size:18px=">
          <tr style="background-color:#87B2F3">
            <th width="30%">Gyártó</th>
            <th width="30%">Modell</th>
            <th width="20%">Kezdeti dátum</th>
            <th width="20%">Végső dátum</th>
            <th width="10%">Számla</th>
          </tr>
          <xsl:for-each select="./Berles">
            <tr>
              <td><xsl:value-of select="GyartoNev"/></td>
              <td><xsl:value-of select="Jarmu"/></td>
              <td><xsl:value-of select="BerlesKezdete"/></td>
              <td><xsl:value-of select="BerlesVege"/></td>
              <td><xsl:value-of select="Szamla"/></td>
            </tr>
          </xsl:for-each>
        </table>
      </xsl:for-each>
    </body>
    </html>
  </xsl:template>
  
</xsl:stylesheet>
