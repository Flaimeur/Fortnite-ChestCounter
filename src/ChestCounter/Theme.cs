namespace ChestCounter;

/// <summary>
/// Style « comme la 1.3 » (fork Flaimeur) : fond gris très sombre, cartes sobres aux coins arrondis, un seul accent
/// doré, titres de section en petites majuscules. Ajouté après les styles d'origine de la fenêtre (GuiPage) et du
/// rapport (ReportWriter) : il ne change que l'apparence, pas la structure des pages.
/// </summary>
public static class Theme
{
    public const string Css = """
        /* ===== Style 1.3 ===== */
        :root:not(#_),:root:not(#_)[data-theme]{color-scheme:dark;
          --bg:#121214;--ink:#ededf0;--ink2:#ededf0;--muted:#9a9aa2;--title:#ededf0;
          --card:#1b1b1f;--cink:#ededf0;--cmuted:#9a9aa2;--line:#2c2c32;--track:#2c2c32;
          --gold:#e9b04f;--accent:#e9b04f;--accent-soft:#33280f;--good:#5cc28a;--star:#b48cff;--team:#3fb6a8;
          --warn:#ff8a73;--warnbg:#33280f}
        html,body{background:var(--bg)}
        body{color:var(--ink);font:15px/1.5 "Segoe UI",system-ui,-apple-system,sans-serif}
        .embed,.embed body{background:transparent!important}

        /* Titres comme la 1.3 : pas de police pirate */
        .pirate,h1,h2{font-family:"Segoe UI",system-ui,sans-serif!important}
        h1{font-size:26px!important;font-weight:700!important;letter-spacing:-.01em;color:var(--ink)!important}
        h2{font-size:15px!important;font-weight:600!important;text-transform:uppercase;letter-spacing:.06em;color:var(--muted)!important}
        h2 .info{border-color:var(--muted)!important;color:var(--muted)!important;vertical-align:1px!important}
        .fold .head h2,.foldbtn{color:var(--muted)!important}
        .num{font-family:"Segoe UI",system-ui,sans-serif;font-stretch:normal;font-variant-numeric:tabular-nums}
        header{border-bottom:none!important;padding-bottom:4px!important}
        footer{border-top:none!important;color:var(--muted)}
        .who,.who b{color:var(--muted)}
        .brand svg{flex:none;border-radius:12px}

        /* Cartes */
        .tile,.card,.hcard,.odds,.notice,.thour,.loading,dialog,.prize{background:var(--card)!important;color:var(--ink)!important;
          border:1px solid var(--line)!important;border-radius:12px!important;box-shadow:none!important}
        .tile .v{color:var(--ink);font-weight:700}
        .tile .l,.tile .s{color:var(--muted)!important}
        .tile.hero{background:var(--accent-soft)!important;border-color:transparent!important;color:var(--ink)!important}
        .tile.hero .v{color:var(--accent)!important}
        .tile.hero .k{color:var(--muted)!important}
        .tile.hero .l{color:var(--muted)!important}
        .editbtn{border-color:var(--line)!important;color:var(--accent)!important;border-radius:8px!important}
        .editbtn:hover{background:rgba(233,176,79,.12)!important}

        /* Onglets */
        nav button{min-height:40px!important;border:1px solid var(--line)!important;border-radius:10px!important;background:var(--card)!important;color:var(--muted)!important}
        nav button:hover{color:var(--ink)!important}
        nav button.on{background:var(--accent-soft)!important;border-color:transparent!important;color:var(--accent)!important}
        .pill{background:var(--card)!important;color:var(--ink)!important;border:1px solid var(--line)}

        /* Boutons et champs */
        button.b,.pager button{background:var(--card)!important;color:var(--ink)!important;border:1px solid var(--line)!important;border-radius:10px!important}
        button.b:hover,.pager button:hover{border-color:#3d3d45!important;background:#222227!important}
        button.b.main{background:var(--accent-soft)!important;color:var(--accent)!important;border-color:transparent!important}
        button.b.danger{color:var(--warn)!important}
        select,input[type=text],input[type=number]{background:var(--bg)!important;color:var(--ink)!important;border:1px solid var(--line)!important;border-radius:8px!important}
        select option,.who select option{background:var(--card)!important;color:var(--ink)!important}
        .who select{border-color:var(--line)!important}
        .switch span,.tsw .trk{background:#3a3a42!important}
        .switch input:checked+span,.tsw input:checked+.trk{background:var(--accent)!important}
        .dclose,.notice .nclose{color:var(--muted)!important;border-color:var(--line)!important}
        .dhead h2{color:var(--ink)!important;text-transform:none}
        .path{background:var(--bg)!important;color:var(--ink)}

        /* Bandeaux */
        .notice,.thour{border-left:1px solid var(--line)!important}
        .notice.warning,.thour.live,.flag{background:var(--accent-soft)!important;border-color:var(--accent)!important;color:var(--ink)!important;border-radius:12px!important}
        .notice .ni{background:var(--accent)!important;color:#121214!important}
        .badge,.exper,.tsw .badge{background:var(--accent-soft)!important;color:var(--accent)!important}
        .boost{background:var(--accent-soft)!important;color:var(--accent)!important}
        .boostv{color:var(--accent)!important}

        /* Tableaux */
        th{color:var(--muted)!important}
        th,td{border-bottom-color:var(--line)!important}
        tr.unusual td{background:var(--accent-soft)!important}
        .items,.iname,.hname .k,.hcard .s,.cfoot,.hrow,.odds .k,.odds .l,.odds .s,.prize .pk,.pager .count{color:var(--muted)!important}
        .cfoot,.axis{border-top-color:var(--line)!important}
        .wk+.wk{border-top-color:var(--line)!important}
        .wk.now .wt,.gold{color:var(--accent)!important}
        .warn{color:var(--warn)!important}

        /* Chances */
        .tag.weekly,.tag.season{background:var(--accent-soft)!important;color:var(--accent)!important}
        .vchip{background:#26262b!important;color:var(--muted)!important}
        .vchip.likely,.vchip.vlikely{color:var(--good)!important}
        .vchip.certain{background:rgba(92,194,138,.16)!important;color:var(--good)!important}
        .cbar,.meter,.pbar{background:var(--line)!important}
        .cbar i,.meter i,.pbar i,.meter.wide i{background:var(--accent)!important}
        .cbar i.likely,.cbar i.vlikely,.cbar i.certain{background:var(--good)!important}
        .chances2 .gotbadge,.ctable .gotbadge{background:rgba(92,194,138,.16)!important;color:var(--good)!important}
        tr.got .tk,.gotbadge{color:var(--good)!important}
        .hcard.got,.odds.got{border-color:var(--good)!important;box-shadow:none!important;padding-left:16px!important}
        .hcard.boosted,.odds.boosted{border-color:var(--accent)!important;box-shadow:none!important;padding-left:16px!important}
        tr.boosted td:first-child{box-shadow:inset 3px 0 0 var(--accent)!important}
        .cd.soon{color:var(--accent)!important}
        .star{color:var(--star)!important}
        .cmore a{color:var(--accent)!important}

        /* Graphique par jour, comme la 1.3 */
        .bar,.bar.top{background:var(--accent)!important;border-radius:3px 3px 0 0!important}
        .bar.zero{background:var(--line)!important}
        .col:hover .bar{filter:brightness(1.25)}
        .tip,.infotip{background:var(--ink)!important;color:var(--bg)!important}

        /* Collection */
        .prize .pimg,.thumb,.cthumb{background:var(--line)!important}
        .prize.got{border:1px solid var(--good)!important;padding:8px!important}

        /* Journal */
        .log{background:var(--card)!important;border:1px solid var(--line)!important}
        .log .err{color:#ff8a73}.log .warn{color:#e9b04f}.log .ok{color:#5cc28a}.log .info{color:#7cc4e8}.log .tre{color:#b48cff}.log .mut{color:#6b6b72}

        /* Fenêtre */
        body.windowed .tbar{background:var(--bg)!important}
        .wctl button:hover{background:rgba(255,255,255,.06)!important;color:var(--ink)!important}
        #scroll::-webkit-scrollbar-thumb,html::-webkit-scrollbar-thumb{background:#2c2c32!important;border-color:var(--bg)!important}
        #scroll::-webkit-scrollbar-thumb:hover,html::-webkit-scrollbar-thumb:hover{background:#3d3d45!important}
        """;
}
