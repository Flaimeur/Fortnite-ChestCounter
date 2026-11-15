namespace ChestCounter;

/// <summary>
/// Thème sombre « moderne » (fork Flaimeur) : ajouté après les styles d'origine de la fenêtre (GuiPage) et du
/// rapport (ReportWriter). Il ne fait que redéfinir couleurs, typo et formes : la structure des pages ne change pas,
/// donc une mise à jour du code d'origine reste facile à reprendre.
/// </summary>
public static class Theme
{
    public const string Css = """
        /* ===== Thème sombre moderne ===== */
        :root:not(#_),:root:not(#_)[data-theme]{color-scheme:dark;
          --bg:#0b0c10;--ink:#e8e9ee;--ink2:#ffffff;--muted:#8b8e9c;--title:#ffffff;
          --card:#15161c;--card2:#1b1d24;--cink:#e8e9ee;--cmuted:#8b8e9c;--line:rgba(255,255,255,.08);--track:#262833;
          --gold:#f2b544;--gold2:#ffcf66;--star:#b69bff;--team:#2cc8b4;--warn:#ff7a6b;--warnbg:rgba(255,122,107,.08);
          --radius:14px;--shadow:0 1px 0 rgba(255,255,255,.04) inset,0 10px 30px rgba(0,0,0,.28)}
        body{background:radial-gradient(1200px 500px at 15% -10%,rgba(242,181,68,.07),transparent 60%),var(--bg) fixed;
          font:15px/1.5 "Segoe UI Variable Text","Segoe UI",system-ui,-apple-system,sans-serif;-webkit-font-smoothing:antialiased}
        html{background:var(--bg)}
        .embed,.embed body{background:transparent!important}
        ::selection{background:rgba(242,181,68,.35)}

        /* Titres : plus de police pirate, une typo nette */
        .pirate,h1,h2{font-family:"Segoe UI Variable Display","Segoe UI",system-ui,sans-serif!important;font-weight:700!important;letter-spacing:-.01em}
        h1{font-size:30px!important;color:var(--ink2)!important}
        h2{font-size:19px!important;color:var(--ink2)!important}
        h2 .info{border-color:var(--cmuted)!important;color:var(--cmuted)!important;vertical-align:2px!important}
        .num{font-family:"Segoe UI Variable Display",Bahnschrift,"Segoe UI",sans-serif;font-stretch:normal;font-variant-numeric:tabular-nums;letter-spacing:-.02em}

        header{border-bottom:1px solid var(--line)!important}
        footer{border-top:1px solid var(--line)!important;color:var(--muted)}
        .who,.who b{color:var(--muted)}

        /* Cartes */
        .tile,.card,.hcard,.odds,.notice,.thour,.loading,dialog,.prize{background:var(--card)!important;color:var(--cink)!important;
          border:1px solid var(--line)!important;border-radius:var(--radius)!important;box-shadow:var(--shadow)}
        .tile{padding:16px 18px!important;transition:border-color .15s,transform .15s}
        .tile:hover{border-color:rgba(255,255,255,.16)!important}
        .tile .v{color:var(--ink2)}
        .tile .l,.tile .s{color:var(--cmuted)!important}
        .tile.hero{background:linear-gradient(140deg,#3b2a0c 0%,#22190a 55%,#17130b 100%)!important;border:1px solid rgba(242,181,68,.45)!important;
          box-shadow:0 0 0 1px rgba(242,181,68,.08) inset,0 14px 40px rgba(242,181,68,.10)!important;color:#f6e6c2!important}
        .tile.hero .v{color:var(--gold2)!important;text-shadow:0 2px 24px rgba(255,207,102,.25)}
        .tile.hero .k{color:#e9c27a!important}
        .tile.hero .l{color:#d9c7a0!important}
        .editbtn{border-color:rgba(242,181,68,.5)!important;color:var(--gold2)!important;border-radius:10px!important}
        .card{padding-left:18px;padding-right:18px}

        /* Navigation en onglets « pilule » */
        nav{background:var(--card);border:1px solid var(--line);border-radius:12px;padding:4px;gap:4px!important;align-self:flex-start}
        nav button{min-height:38px!important;border:0!important;border-radius:9px!important;color:var(--muted)!important;background:transparent!important;
          padding:6px 18px!important;transition:background .15s,color .15s}
        nav button:hover{color:var(--ink2)!important;background:rgba(255,255,255,.05)!important}
        nav button.on{background:linear-gradient(180deg,var(--gold2),var(--gold))!important;color:#1d1405!important;box-shadow:0 4px 14px rgba(242,181,68,.25)}
        .pill{background:var(--card)!important;color:var(--ink)!important;border:1px solid var(--line)}

        /* Boutons et champs */
        button.b,.pager button{background:var(--card2)!important;color:var(--ink)!important;border:1px solid rgba(255,255,255,.12)!important;border-radius:10px!important;transition:background .15s,border-color .15s}
        button.b:hover,.pager button:hover{background:#252731!important;border-color:rgba(255,255,255,.2)!important}
        button.b.main{background:linear-gradient(180deg,var(--gold2),var(--gold))!important;color:#1d1405!important;border-color:transparent!important}
        button.b.main:hover{filter:brightness(1.06)}
        button.b.danger{color:var(--warn)!important;border-color:rgba(255,122,107,.45)!important}
        select,input[type=text],input[type=number]{background:#0f1015!important;color:var(--ink)!important;border:1px solid rgba(255,255,255,.12)!important;border-radius:10px!important}
        select option,.who select option{background:#15161c!important;color:var(--ink)!important}
        .who select{border-color:rgba(255,255,255,.14)!important}
        .switch span,.tsw .trk{background:#33353f!important}
        .switch input:checked+span,.tsw input:checked+.trk{background:var(--team)!important}
        .dclose,.notice .nclose{color:var(--cmuted)!important;border-color:var(--line)!important}
        .dhead h2{color:var(--ink2)!important}
        dialog::backdrop{background:rgba(0,0,0,.6);backdrop-filter:blur(2px)}
        .path{background:#0f1015!important;color:var(--ink)}

        /* Bandeaux */
        .notice,.thour{border-left:4px solid var(--gold)!important}
        .notice.warning,.thour.live{border-left-color:var(--warn)!important;background:linear-gradient(90deg,rgba(255,122,107,.10),var(--card) 60%)!important}
        .notice .ni{background:var(--gold)!important;color:#1d1405!important}
        .notice.warning .ni{background:var(--warn)!important;color:#fff!important}
        .flag{background:rgba(255,122,107,.08)!important;color:#ffd1ca!important;border:1px solid rgba(255,122,107,.4)!important;border-radius:var(--radius)!important}
        .badge,.exper,.tsw .badge{background:rgba(255,122,107,.14)!important;color:#ffa497!important}
        .boost{background:rgba(251,146,60,.16)!important;color:#fdba74!important}
        .boostv{color:#fdba74!important}

        /* Tableaux */
        th{color:var(--cmuted)!important}
        th,td{border-bottom-color:var(--line)!important}
        tr.unusual td{background:var(--warnbg)!important}
        tbody tr:hover td{background:rgba(255,255,255,.02)}
        .items,.iname,.hname .k,.hcard .s,.cfoot,.hrow,.odds .k,.odds .l,.odds .s,.prize .pk,.pager .count{color:var(--cmuted)!important}
        .cfoot,.axis{border-top-color:var(--line)!important}
        .wk+.wk{border-top-color:var(--line)!important}
        .wk.now .wt,.gold{color:var(--gold)!important}

        /* Puces et barres de chance */
        .tag.weekly{background:rgba(96,165,250,.16)!important;color:#93c5fd!important}
        .tag.season{background:rgba(182,155,255,.16)!important;color:#cbb8ff!important}
        .vchip.vunlikely{background:rgba(255,255,255,.06)!important;color:#a3a6b4!important}
        .vchip.unlikely{background:rgba(242,181,68,.12)!important;color:#f2c66d!important}
        .vchip.possible{background:rgba(251,191,36,.18)!important;color:#fcd34d!important}
        .vchip.likely{background:rgba(74,222,128,.12)!important;color:#86efac!important}
        .vchip.vlikely{background:rgba(74,222,128,.18)!important;color:#4ade80!important}
        .vchip.certain{background:rgba(34,197,94,.24)!important;color:#bbf7d0!important}
        .cbar,.meter,.pbar,.bar:not(.zero){border-radius:999px}
        .cbar,.meter,.pbar{background:var(--track)!important}
        .cbar i,.meter i,.pbar i{border-radius:999px}
        .cbar i.vunlikely,.cbar i.unlikely,.cbar i.gold,.meter.wide i,.pbar i{background:var(--gold)!important}
        .cbar i.possible{background:#f59e0b!important}
        .cbar i.likely,.cbar i.vlikely{background:#4ade80!important}
        .cbar i.certain{background:#22c55e!important}
        .chances2 .gotbadge,.ctable .gotbadge{background:rgba(44,200,180,.16)!important;color:#5eead4!important}
        tr.got .tk,.gotbadge{color:#5eead4}
        .hcard.got,.odds.got{border-color:rgba(44,200,180,.45)!important;box-shadow:inset 4px 0 0 var(--team),var(--shadow)!important}
        .hcard.boosted,.odds.boosted{border-color:rgba(251,146,60,.5)!important;box-shadow:inset 4px 0 0 #fb923c,var(--shadow)!important}
        .hval .big{color:var(--ink2)}
        .cd.soon{color:#fdba74!important}
        .star{color:var(--star)!important}
        .cmore a{color:var(--gold)!important}

        /* Graphique par jour */
        .bar{background:linear-gradient(180deg,var(--gold2),#c98d24)!important;border-radius:6px 6px 2px 2px!important}
        .bar.top{background:linear-gradient(180deg,#ffd27a,#f2994a)!important;box-shadow:0 0 18px rgba(242,153,74,.35)}
        .bar.zero{background:var(--track)!important}
        .tip,.infotip{background:#f3f4f7!important;color:#14151a!important;box-shadow:0 8px 24px rgba(0,0,0,.45)}

        /* Collection */
        .prize .pimg,.thumb,.cthumb{background:var(--track)!important}
        .prize.got{border:1px solid rgba(44,200,180,.6)!important;padding:8px!important;box-shadow:0 0 0 1px rgba(44,200,180,.25) inset,var(--shadow)}

        /* Journal d'activité */
        .log{background:#0f1015!important;border:1px solid var(--line)!important}
        .log .err{color:#ff8a7a}.log .warn{color:#fcd34d}.log .ok{color:#4ade80}.log .info{color:#7dd3fc}.log .tre{color:#cbb8ff}.log .mut{color:#6b6e7c}

        /* Fenêtre */
        body.windowed .tbar{background:rgba(11,12,16,.85)!important;backdrop-filter:blur(8px)}
        .wctl button:hover{background:rgba(255,255,255,.07)!important;color:var(--ink2)!important}
        #scroll::-webkit-scrollbar-thumb,html::-webkit-scrollbar-thumb{background:rgba(255,255,255,.14)!important}
        #scroll::-webkit-scrollbar-thumb:hover,html::-webkit-scrollbar-thumb:hover{background:rgba(255,255,255,.24)!important}
        .log::-webkit-scrollbar-thumb{background:rgba(255,255,255,.12)!important;border-color:#0f1015!important}
        """;
}
