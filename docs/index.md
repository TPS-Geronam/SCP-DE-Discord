# KIRA_BOT

For the English version (F.KIRA), see [this](english.md) page.

Diese Seite enthält die Dokumentation zu KIRA_BOT, dessen Commands und Events. KIRA_BOT wurde von [TPS-Geronam](https://github.com/TPS-Geronam) entwickelt und wird auf dem SCP-DE-Discord eingesetzt. Fehler, Vorschläge und sonstiges Feeback bitte per PN in Discord einreichen (TPS-Geronam#2922).

`<>` = Pflichtparameter

`[]` = optionale Parameter

`Aliases` sind alternative Namen der Commands.

## Commands

### Allgemeine Commands

> !help

**Beschreibung:** Zeigt eine Liste aller für den einfachen User zugängelicher Commands an.

**Berechtigungen:** /

**Aliases:** /

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

> !format

<br><br>

> !witz

**Beschreibung:** Erzählt einen Witz aus einer in diesem Repo vorhandenen Liste.

**Berechtigungen:** `Personal`-Rolle

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

> !dice [seiten] [anzahl]

**Beschreibung:** Würfelt einen Würfel. Wenn die `[seiten]` oder die `[anzahl]` nicht angegeben wird, werden die Werte `6` und `1` verwendet.

**Berechtigungen:** /

**Aliases:** `!würfel [seiten] [anzahl]`

<br><br>

> !willkommen <user>

**Beschreibung:** Heißt `<user>` mit einem zufälligen Satz willkommen.

**Berechtigungen:** /

**Aliases:** `!welcome <user>`

<br><br>

> !syntax <command>

**Beschreibung:** Zeigt die Syntax von einem Command an. `<command>` entspricht dem Command ohne dem Prefix.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !steam <titel>

**Beschreibung:** Sucht nach einem Spiel in Steam. `<titel>` entspricht dem Spieletitel, nach dem gesucht werden soll. Abkürzungen wie `CSGO`, `TF2` oder `CoD` werden nicht unterstützt.

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !feedback <text>

**Beschreibung:** Sendet Feedback über Discord/Wiki/KIRA an die O4s. Nur in PNs ausführbar.

**Berechtigungen:** `Personal`-Rolle, Channel.IsPrivate

**Aliases:** /

<br><br>

#### Tag-Commands

**Q:** Was sind Tags?

**A:** Tags sind sogesehen beschriftete Container mit Inhalt. Der Name auf dem Container gleicht dem Namen des Tags, der Inhalt des Containers gleicht dem Inhalt des Tags. So kann z.B. als Inhalt ein Link oder sonstiger Text dienen.

<br><br>

> !tag show all

**Beschreibung:** Listet alle Tags auf (Namen).

**Berechtigungen:** /

**Aliases:** /

<br><br>

> !tag add <name> <inhalt>

**Beschreibung:** Erstellt einen neuen Tag. `<name>` entspricht dem Namen und `<inhalt>` dem Inhalt in Form von Text des Tags.

**Berechtigungen:** GuildPermission.ManageChannels

**Aliases:** /

<br><br>

> !tag add-embed <name> <thumbnail-url> <autor> <autor-icon-url> <titel> <beschreibung> <feld-name> <feld-inhalt> <bild-url> <footer-text> <footer-icon-url>

**Beschreibung:** Erstellt einen neuen Tag mit einem Embed. `<name>` ist der Name, `<thumbnail-url>` ist die URL zu dem Thumbnail, `<autor>` ist der Name des Autors, `<autor-icon-url>` ist der Link zu dem Autor-Icon, `<titel>` ist der Titel des Embeds, `<beschreibung>` ist die Beschreibung des Embeds, `<feld-name>` ist der Name bzw. Titel des Feldes, `<feld-inhalt>` ist der Inhalt in Form von Text des Feldes, `<bild-url>` ist die URL zu dem Bild, `<footer-text>` ist der Text im Footer und `<footer-icon-url>` ist die URL zu dem Bild im Footer.

**Berechtigungen:** GuildPermission.ManageChannels

**Aliases:** /

**Notizen:** Jeder Parameter werden mit Anführungszeichen angegeben, damit Leerzeichen akzeptiert werden können. Falls ein Parameter leer bleiben soll, so muss `""` verwendet werden.

<br><br>

> !tag delete <name>

**Beschreibung:** Entfernt einen Tag. `<name>` entspricht dem Namen des Tags, der entfernt werden soll.

**Berechtigungen:** GuildPermission.ManageChannels

**Aliases:** /

<br><br>

> !tag <name>

**Beschreibung:** Zeigt einen Tag mit dessen Inhalt an. `<name>` entspricht dem Namen des Tags, der angezeigt werden soll.

**Berechtigungen:** /

**Aliases:** /

<br><br>

#### Kritik-Commands

> !kritik liste

**Beschreibung:** Zeigt die Kritik-Liste an.

**Berechtigungen:** `Personal`-Rolle

**Aliases:** /

<br><br>

> !kritik neu <user> <link>

**Beschreibung:** Erstellt einen neuen Kritik-Eintrag. `<user>` entspricht dem Autor und `<link>` dem Link zu der Sandbox/dem Forum-Thread.

**Berechtigungen:** `Personal`-Rolle

**Aliases:** /

<br><br>

> !kritik entfernen <id>

**Beschreibung:** Löscht einen Kritik-Eintrag. `<id>` entspricht der ID des Eintrags, die mit `!kritik liste` einsehbar ist.

**Berechtigungen:** `Personal`-Rolle

**Aliases:** /

<br><br>

### Link-Commands

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

> !google <text>

**Beschreibung:** Verlink etwas bei Google, indem `<text>` an `https://www.google.de/`angehängt wird.

**Berechtigungen:** /

**Aliases:** `!g <text>`

<br><br>

**Beschreibung:** Verlinkt die Support-Seite zu der Formatierung von Discord.

**Berechtigungen:** /

**Aliases:** `!markdown`

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

<br><br>

#### Such-Commands

> !search <zweig> <name>

**Beschreibung:** Sucht nach einem Artikel. `<zweig>` entspricht dem Kürzel des Zweigs, in dem gesucht werden soll, und `<name>` entpsricht dem gesuchten Seitennamen.

**Berechtigungen:** /

**Aliases:** `!suchen <zweig> <name>`, `!s <zweig> <name>`

<br><br>

> !search-tags <zweig> <tags>

**Beschreibung:** Sucht nach einem Artikel mit Tags. `<zweig>` entspricht dem Kürzel des Zweigs, in dem gesucht werden soll, und `<tags>` entpsricht den Tags, mit denen gesucht werden soll. Tags werden mit einem Komma ohne Leerzeichen abgetrennt (`,`). Ein Minus (`-`) vor einem Tag (ebenfalls ohne Leerzeichen) bedeutet, dass die Seiten mit diesem Tag nicht aufgeführt werden. Ein Plus (`+`) vor einem Tag bedeutet, dass die Seiten mit diesem Tag angezeigt werden müssen.

**Berechtigungen:** /

**Aliases:** `!suchen-tags <zweig> <tags>`, `!st <zweig> <tags>`

<br><br>

> !search-user <zweig> <username>

**Beschreibung:** Sucht nach einem User mit dessen Namen. `<zweig>` entspricht dem Kürzel des Zweigs, in dem gesucht werden soll, und `<username>` entpsricht dem Usernamen des gesuchten Users.

**Berechtigungen:** /

**Aliases:** `!suchen-user <zweig> <username>`, `!su <zweig> <username>`

<br><br>

### Spezielle Commands

> !guid

**Beschreibung:** Erzeugt eine GUID für `!shd`.

**Berechtigungen:** GuildPermission.ManageChannels

**Aliases:** /

<br><br>

> !shd <guid>

**Beschreibung:** Fährt den Bot herunter, solange die richtige GUID angegeben wird.

**Berechtigungen:** GuildPermission.ManageChannels

**Aliases:** /
