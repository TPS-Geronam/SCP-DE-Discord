# KIRA_BOT

For the English version (F.KIRA), see [this](english.md) page.

Diese Seite enthält die Dokumentation zu KIRA_BOT, dessen Commands und Events. KIRA_BOT wurde von [TPS-Geronam](https://github.com/TPS-Geronam) entwickelt und wird auf dem SCP-DE-Discord eingesetzt. Fehler, Vorschläge und sonstiges Feeback bitte per PN in Discord einreichen (TPS-Geronam#2922).

`<>` = Pflichtparameter

`[]` = optionale Parameter

`Aliases` sind alternative Namen der Commands.

## Commands

> !help

**Beschreibung:** Zeigt eine Liste aller für den einfachen User zugängelicher Commands an.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !seite-o <link>

**Beschreibung:** Verlinkt eine Seite im DE-Wiki, indem `<link>` an `http://scp-wiki-de.wikidot.com/` angehängt wird.

**Berechtigungen:** /

**Aliases:** `!s-o <link>`

<br><br>

> !en-seite-o <link>

**Beschreibung:** Verlinkt eine Seite im EN-Wiki, indem `<link>` an `http://scp-wiki.net/` angehängt wird.

**Berechtigungen:** /

**Aliases:** `!en-s-o <link>`

<br><br>

> !int-seite-o <link>

**Beschreibung:** Verlinkt eine Seite im INT-Wiki, indem `<link>` an `http://scp-int.wikidot.com/` angehängt wird.

**Berechtigungen:** /

**Aliases:** `!int-s-o <link>`

<br><br>

> !user [user]

**Beschreibung:** Zeigt Info über den angegebenen User an (`@Username#1234`). Wenn kein User angegeben wird, zeigt der Command Info über denjenigen an, der den Command ausgeführt hat.

**Berechtigungen:** /

**Aliases:** `!userinfo [user]`

<br><br>

> !info

**Beschreibung:** Zeigt Info über KIRA an.

**Berechtigungen:** /

**Aliases:** `!status`

<br><br>

> !google <text>

**Beschreibung:** Verlink etwas bei Google, indem `<text>` an `https://www.google.de/`angehängt wird.

**Berechtigungen:** /

**Aliases:** `!g <text>`

<br><br>

> !format

**Beschreibung:** Verlinkt die Support-Seite zu der Formatierung von Discord.

**Berechtigungen:** /

**Aliases:** `!markdown`

<br><br>

> !witz

**Beschreibung:** Erzählt einen Witz aus einer in diesem Repo vorhandenen Liste.

**Berechtigungen:** `Personal`-Rolle

**Aliases:** /

<br><br>

> !scp-de

**Beschreibung:** Verlinkt die deutsche SCP-DE-Liste.

**Berechtigungen:** /

**Aliases:** `!de-scp`

<br><br>

> !achievements

**Beschreibung:** Verlinkt die deutsche Achievements-Liste.

**Berechtigungen:** /

**Aliases:** `!achievement`

<br><br>

> !referenz

**Beschreibung:** Verlinkt die deutsche Referenz-Liste.

**Berechtigungen:** /

**Aliases:** `!referenzliste`

<br><br>

> !artwork <user>

**Beschreibung:** Verlinkt eine Artwork-Seite von `<user>`, solange dieser in der Liste in diesem Repo angegeben ist.

**Berechtigungen:** /

**Aliases:** `!art`, `!fanart`

<br><br>

> !wiki

**Beschreibung:** Verlinkt die Hauptseite des SCP-DE-Wikis.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !sandbox [link]

**Beschreibung:** Verlinkt die Hauptseite und den Index der SCP-DE-Sandbox. Wenn `[link]` angegeben ist, wird eine Sandbox verlinkt, indem `[link]` an `http://scpsandboxde.wikidot.com/` angehängt wird.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !chars

**Beschreibung:** Verlinkt die Charakter-Seite des SCP-DE-Wikis.

**Berechtigungen:** /

**Aliases:** `!charaktere`

<br><br>

> !guid

**Beschreibung:** Erzeugt eine GUID für `!shd`.

**Berechtigungen:** GuildPermission.ManageChannels

**Aliases:** /

<br><br>

> !shd <guid>

**Beschreibung:** Fährt den Bot herunter, solange die richtige GUID angegeben wird.

**Berechtigungen:** GuildPermission.ManageChannels

**Aliases:** /

<br><br>

> !danke

**Beschreibung:** Antwortet mit einem zufälligen Satz.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !danke <user>

**Beschreibung:** Bedankt sich bei `<user>` mit einem zufälligen Satz.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !willkommen <user>

**Beschreibung:** Heißt `<user>` mit einem zufälligen Satz willkommen.

**Berechtigungen:** /

**Aliases:** `!welcome <user>`

<br><br>

> !dice [seiten] [anzahl]

**Beschreibung:** Würfelt einen Würfel. Wenn die `[seiten]` oder die `[anzahl]` nicht angegeben wird, werden die Werte `6` und `1` verwendet.

**Berechtigungen:** /

**Aliases:** `!würfel [seiten] [anzahl]`

<br><br>

> !dice [seiten] [anzahl]

**Beschreibung:** Würfelt einen Würfel. Wenn die `[seiten]` oder die `[anzahl]` nicht angegeben wird, werden die Werte `6` und `1` verwendet.

**Berechtigungen:** /

**Aliases:** `!würfel [seiten] [anzahl]`

<br><br>

> !forum

**Beschreibung:** Verlinkt die Forum-Startseite des SCP-DE-Wikis.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !scp-schreiben

**Beschreibung:** Verlinkt Hilfe-Seiten zum SCP-Schreiben des SCP-DE-Wikis, darunter den Neueinsteiger-Guide, "Wie schreibt man ein SCP?" und die allgemeine Hilfe-Seite.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !de-credits

**Beschreibung:** Verlinkt die Credits-Seite der SCP-DEs des SCP-DE-Wikis.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !de-kanon <name>

**Beschreibung:** Verlinkt einen Kanon des SCP-DE-Wikis, solange `<name>` in der Liste in diesem Repo angegeben ist.

**Berechtigungen:** /

**Aliases:** `!kanon <name>`, `!canon <name>`

<br><br>

> !de-goi <kuerzel>

**Beschreibung:** Verlinkt eine GoI des SCP-DE-Wikis, solange `<kuerzel>` in der Liste in diesem Repo angegeben ist.

**Berechtigungen:** /

**Aliases:** `!goi <kuerzel>`

<br><br>

> !autor <name>

**Beschreibung:** Verlinkt einen Autor des SCP-DE-Wikis, solange `<name>` in der Liste in diesem Repo angegeben ist.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !branch <kuerzel>

**Beschreibung:** Verlinkt einen Zweig und dessen Discord, solange `<kuerzel>` in der Liste in diesem Repo angegeben ist.

**Berechtigungen:** /

**Aliases:** /
