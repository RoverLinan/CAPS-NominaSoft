ê
eC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str +
)+ ,
], -
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str -
)- .
]. /
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *Ú
nC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Servicios\GenerarNumeroAleatorio.cs
	namespace 	
Capa2_Aplicacion
 
. 
	Servicios $
{		 
public

 

static

 
class

 "
GenerarNumeroAleatorio

 /
{ 
public 
static 
String "
ObtenerNumeroAleatorio 3
(3 4
)4 5
{ 	
var 
randomGenerator 
=  !!
RandomNumberGenerator" 7
.7 8
Create8 >
(> ?
)? @
;@ A
byte 
[ 
] 
data 
= 
new 
byte "
[" #
$num# $
]$ %
;% &
randomGenerator 
. 
GetBytes $
($ %
data% )
)) *
;* +
return 
BitConverter 
.  
ToString  (
(( )
data) -
)- .
;. /
} 	
} 
}  
lC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Servicios\GestionarAfpServicio.cs
	namespace

 	
Capa2_Aplicacion


 
.

 
	Servicios

 $
{ 
public 

class  
GestionarAfpServicio %
{ 
private 
readonly 
GestorSqlServer (
	gestorSQL) 2
=3 4
GestorSqlServer5 D
.D E
getInstanceE P
(P Q
)Q R
;R S
private 
readonly 
AfpSqlServer %
afpSQL& ,
=. /
new0 3
AfpSqlServer4 @
(@ A
)A B
;B C
public  
GestionarAfpServicio #
(# $
)$ %
{ 	
} 	
public 
void 

guardarAfp 
( 
Afp "
afp# &
)& '
{ 	
try 
{ 
	gestorSQL 
. 
AbrirConexion '
(' (
)( )
;) *
afpSQL 
. 
guardar 
( 
afp "
)" #
;# $
	gestorSQL 
. 
CerrarConexion (
(( )
)) *
;* +
} 
catch   
(   
SqlException   
err    #
)  # $
{!! 
Console"" 
."" 
	WriteLine"" !
(""! "
err""" %
.""% &
ToString""& .
("". /
)""/ 0
)""0 1
;""1 2
throw## 
;## 
}$$ 
}'' 	
public)) 
Afp)) 
buscarAfpPorId)) !
())! "
int))" %
id))& (
)))( )
{** 	
try,, 
{-- 
	gestorSQL.. 
... 
AbrirConexion.. '
(..' (
)..( )
;..) *
Afp// 
afp// 
=// 
afpSQL//  
.//  !
buscarAfpPorId//! /
(/// 0
id//0 2
)//2 3
;//3 4
	gestorSQL00 
.00 
CerrarConexion00 (
(00( )
)00) *
;00* +
return22 
afp22 
;22 
}33 
catch44 
(44 
SqlException44 
err44  #
)44# $
{55 
Console66 
.66 
	WriteLine66 !
(66! "
err66" %
.66% &
ToString66& .
(66. /
)66/ 0
)660 1
;661 2
throw77 
;77 
}88 
}:: 	
public<< 
List<< 
<<< 
Afp<< 
><< 
obtenerListaAfp<< (
(<<( )
)<<) *
{== 	
try>> 
{?? 
	gestorSQL@@ 
.@@ 
AbrirConexion@@ '
(@@' (
)@@( )
;@@) *
ListAA 
<AA 
AfpAA 
>AA 
listaAfpAA "
=AA# $
afpSQLAA% +
.AA+ ,
listaAfpAA, 4
(AA4 5
)AA5 6
;AA6 7
	gestorSQLBB 
.BB 
CerrarConexionBB (
(BB( )
)BB) *
;BB* +
returnDD 
listaAfpDD 
;DD  
}EE 
catchFF 
(FF 
SqlExceptionFF 
errFF  #
)FF# $
{GG 
ConsoleHH 
.HH 
	WriteLineHH !
(HH! "
errHH" %
.HH% &
ToStringHH& .
(HH. /
)HH/ 0
)HH0 1
;HH1 2
throwII 
;II 
}JJ 
}KK 	
}LL 
}MM Ω)
uC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Servicios\GestionarBoletaDePagoServicio.cs
	namespace		 	
Capa2_Aplicacion		
 
.		 
	Servicios		 $
{

 
public 

class )
GestionarBoletaDePagoServicio .
{ 
private 
readonly 
GestorSqlServer (
	gestorSQL) 2
;2 3
private 
readonly !
BoletaDePagoSqlServer .
boletaDePagoSQL/ >
;> ?
private 
readonly %
GestionarContratoServicio 2
contratoServicio3 C
;C D
public )
GestionarBoletaDePagoServicio ,
(, -
)- .
{ 	
	gestorSQL 
= 
GestorSqlServer '
.' (
getInstance( 3
(3 4
)4 5
;5 6
boletaDePagoSQL 
= 
new !!
BoletaDePagoSqlServer" 7
(7 8
)8 9
;9 :
contratoServicio 
= 
new "%
GestionarContratoServicio# <
(< =
)= >
;> ?
} 	
public 
bool 
guardar 
( 
BoletaDePago (
boleta) /
)/ 0
{ 	
try 
{ 
	gestorSQL!! 
.!! 
AbrirConexion!! '
(!!' (
)!!( )
;!!) *
boletaDePagoSQL"" 
.""  
guardar""  '
(""' (
boleta""( .
)"". /
;""/ 0
	gestorSQL## 
.## 
CerrarConexion## (
(##( )
)##) *
;##* +
return$$ 
true$$ 
;$$ 
}%% 
catch&& 
(&& 
	Exception&& 
err&&  
)&&  !
{'' 
Console)) 
.)) 
	WriteLine)) !
())! "
err))" %
.))% &
ToString))& .
()). /
)))/ 0
)))0 1
;))1 2
throw** 
;** 
}++ 
}.. 	
public00 
void00 
eliminarPorIdNomina00 '
(00' (
string00( .
id00/ 1
)001 2
{11 	
try22 
{33 
	gestorSQL55 
.55 
AbrirConexion55 '
(55' (
)55( )
;55) *
boletaDePagoSQL66 
.66  
eliminarPorIdNomina66  3
(663 4
id664 6
)666 7
;667 8
	gestorSQL77 
.77 
CerrarConexion77 (
(77( )
)77) *
;77* +
}99 
catch:: 
(:: 
	Exception:: 
err::  
)::  !
{;; 
Console== 
.== 
	WriteLine== !
(==! "
err==" %
.==% &
ToString==& .
(==. /
)==/ 0
)==0 1
;==1 2
throw>> 
;>> 
}?? 
}DD 	
publicGG 
ListGG 
<GG 
BoletaDePagoGG  
>GG  !$
buscarBoletasPorIdNominaGG" :
(GG: ;
NominaGG; A
nominaGGB H
)GGH I
{HH 	
tryII 
{JJ 
	gestorSQLKK 
.KK 
AbrirConexionKK '
(KK' (
)KK( )
;KK) *
ListLL 
<LL 
BoletaDePagoLL !
>LL! "
listaBoletasLL# /
=LL0 1
boletaDePagoSQLLL2 A
.LLA B
buscarPorIdNominaLLB S
(LLS T
nominaLLT Z
)LLZ [
;LL[ \
	gestorSQLMM 
.MM 
CerrarConexionMM (
(MM( )
)MM) *
;MM* +
ListOO 
<OO 
ContratoOO 
>OO 
listaContratosOO -
=OO. /
contratoServicioOO0 @
.OO@ A
obtenerContratosOOA Q
(OOQ R
)OOR S
;OOS T
foreachRR 
(RR 
BoletaDePagoRR %
boletaRR& ,
inRR- /
listaBoletasRR0 <
)RR< =
{SS 
foreachTT 
(TT 
ContratoTT %
contratoTT& .
inTT/ 1
listaContratosTT2 @
)TT@ A
{UU 
ifVV 
(VV 
boletaVV "
.VV" #
ContratoVV# +
.VV+ ,
Contrato_idVV, 7
.VV7 8
EqualsVV8 >
(VV> ?
contratoVV? G
.VVG H
Contrato_idVVH S
)VVS T
)VVT U
{WW 
boletaXX "
.XX" #
ContratoXX# +
=XX, -
contratoXX. 6
;XX6 7
breakYY !
;YY! "
}ZZ 
}[[ 
}]] 
return`` 
listaBoletas`` #
;``# $
}aa 
catchbb 
(bb 
	Exceptionbb 
errbb  
)bb  !
{cc 
Consoleee 
.ee 
	WriteLineee !
(ee! "
erree" %
.ee% &
ToStringee& .
(ee. /
)ee/ 0
)ee0 1
;ee1 2
throwff 
;ff 
}gg 
}kk 	
}pp 
}qq ‚Q
qC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Servicios\GestionarContratoServicio.cs
	namespace		 	
Capa2_Aplicacion		
 
.		 
	Servicios		 $
{

 
public 

class %
GestionarContratoServicio *
{ 
private 
readonly 
ContratoSqlServer *
contratoSQLServer+ <
;< =
private 
readonly  
GestionarAfpServicio -
afpServicio. 9
;9 :
private 
readonly %
GestionarEmpleadoServicio 2
empleadoServicio3 C
;C D
private 
readonly .
"GestionarIncidenciaLaboralServicio ;%
incidenciaLaboralServicio< U
;U V
private 
readonly 
GestorSqlServer (
	gestorSQL) 2
;2 3
public %
GestionarContratoServicio (
(( )
)) *
{ 	
contratoSQLServer 
= 
new  #
ContratoSqlServer$ 5
(5 6
)6 7
;7 8
afpServicio 
= 
new  
GestionarAfpServicio 2
(2 3
)3 4
;4 5
empleadoServicio 
= 
new  #%
GestionarEmpleadoServicio$ =
(= >
)> ?
;? @%
incidenciaLaboralServicio %
=& '
new( +.
"GestionarIncidenciaLaboralServicio, N
(N O
)O P
;P Q
	gestorSQL 
= 
GestorSqlServer '
.' (
getInstance( 3
(3 4
)4 5
;5 6
} 	
public 
Contrato 
buscarPorId #
(# $
string$ *
id+ -
)- .
{   	
try!! 
{"" 
	gestorSQL## 
.## 
AbrirConexion## '
(##' (
)##( )
;##) *
Contrato$$ 
contrato$$ !
=$$" #
contratoSQLServer$$$ 5
.$$5 6
buscarPorId$$6 A
($$A B
id$$B D
)$$D E
;$$E F
	gestorSQL%% 
.%% 
CerrarConexion%% (
(%%( )
)%%) *
;%%* +
return&& 
contrato&& 
;&&  
}'' 
catch(( 
((( 
	Exception(( 
err((  
)((  !
{)) 
Console++ 
.++ 
	WriteLine++ !
(++! "
err++" %
.++% &
ToString++& .
(++. /
)++/ 0
)++0 1
;++1 2
throw,, 
;,, 
}-- 
}// 	
public55 
void55 
guardarContrato55 #
(55# $
Contrato55$ ,
contrato55- 5
)555 6
{66 	
try88 
{99 
	gestorSQL;; 
.;; 
AbrirConexion;; '
(;;' (
);;( )
;;;) *
contratoSQLServer<< !
.<<! "
guardar<<" )
(<<) *
contrato<<* 2
)<<2 3
;<<3 4
	gestorSQL== 
.== 
CerrarConexion== (
(==( )
)==) *
;==* +
}?? 
catch@@ 
(@@ 
	Exception@@ 
err@@  
)@@  !
{AA 
ConsoleBB 
.BB 
	WriteLineBB !
(BB" #
errBB# &
.BB& '
ToStringBB' /
(BB/ 0
)BB0 1
)BB1 2
;BB2 3
throwCC 
;CC 
}DD 
}FF 	
publicHH 
ContratoHH .
"buscarContratoVigentePorIdEmpleadoHH :
(HH: ;
stringHH; A
idHHB D
)HHD E
{II 	
ContratoJJ 
contratoJJ 
;JJ 
tryKK 
{LL 
	gestorSQLMM 
.MM 
AbrirConexionMM '
(MM' (
)MM( )
;MM) *
contratoNN 
=NN 
contratoSQLServerNN ,
.NN, -.
"buscarContratoVigentePorIdEmpleadoNN- O
(NNO P
idNNP R
)NNR S
;NNS T
	gestorSQLOO 
.OO 
CerrarConexionOO (
(OO( )
)OO) *
;OO* +
returnPP 
contratoPP 
;PP  
}QQ 
catchRR 
(RR 
	ExceptionRR 
errRR  
)RR  !
{SS 
ConsoleTT 
.TT 
	WriteLineTT !
(TT" #
errTT# &
.TT& '
ToStringTT' /
(TT/ 0
)TT0 1
)TT1 2
;TT2 3
throwUU 
;UU 
}VV 
}XX 	
publicZZ 
ListZZ 
<ZZ 
ContratoZZ 
>ZZ (
buscarContratosPorIdEmpleadoZZ :
(ZZ: ;
stringZZ; A
idZZB D
)ZZD E
{[[ 	
List\\ 
<\\ 
Contrato\\ 
>\\ 
	contratos\\ $
;\\$ %
try]] 
{^^ 
	gestorSQL__ 
.__ 
AbrirConexion__ '
(__' (
)__( )
;__) *
	contratos`` 
=`` 
contratoSQLServer`` -
.``- .(
buscarContratosPorIdEmpleado``. J
(``J K
id``K M
)``M N
;``N O
	gestorSQLaa 
.aa 
CerrarConexionaa (
(aa( )
)aa) *
;aa* +
returnbb 
	contratosbb  
;bb  !
}cc 
catchdd 
(dd 
	Exceptiondd 
errdd  
)dd  !
{ee 
Consoleff 
.ff 
	WriteLineff !
(ff! "
errff" %
.ff% &
ToStringff& .
(ff. /
)ff/ 0
)ff0 1
;ff1 2
throwgg 
;gg 
}hh 
}jj 	
publicmm 
Listmm 
<mm 
Contratomm 
>mm 
obtenerContratosmm .
(mm. /
)mm/ 0
{nn 	
trypp 
{qq 
Listss 
<ss 
Contratoss 
>ss 
	contratosss (
;ss( )
	gestorSQLtt 
.tt 
AbrirConexiontt '
(tt' (
)tt( )
;tt) *
	contratosuu 
=uu 
contratoSQLServeruu -
.uu- .
obtenerContratosuu. >
(uu> ?
)uu? @
;uu@ A
	gestorSQLvv 
.vv 
CerrarConexionvv (
(vv( )
)vv) *
;vv* +
foreachyy 
(yy 
Contratoyy !
itemyy" &
inyy' )
	contratosyy* 3
)yy3 4
{zz 
item{{ 
.{{ 
Afp{{ 
={{ 
afpServicio{{ *
.{{* +
buscarAfpPorId{{+ 9
({{9 :
item{{: >
.{{> ?
Afp{{? B
.{{B C
Afp_id{{C I
){{I J
;{{J K
item|| 
.|| 
Empleado|| !
=||" #
empleadoServicio||$ 4
.||4 5
buscarEmpleadoPorId||5 H
(||H I
item||I M
.||M N
Empleado||N V
.||V W
Empleado_id||W b
)||b c
;||c d
item~~ 
.~~ 
Incidencias~~ $
=~~% &%
incidenciaLaboralServicio~~' @
.~~@ A%
obtenerListaPorIdContrato~~A Z
(~~Z [
item~~[ _
.~~_ `
Contrato_id~~` k
)~~k l
;~~l m
}
ÅÅ 
return
ÉÉ 
	contratos
ÉÉ  
;
ÉÉ  !
}
ÑÑ 
catch
ÖÖ 
(
ÖÖ 
	Exception
ÖÖ 
err
ÖÖ  
)
ÖÖ  !
{
ÜÜ 
Console
áá 
.
áá 
	WriteLine
áá !
(
áá! "
err
áá" %
.
áá% &
ToString
áá& .
(
áá. /
)
áá/ 0
)
áá0 1
;
áá1 2
throw
àà 
;
àà 
}
ââ 
}
ää 	
public
åå 
bool
åå  
actualizarContrato
åå &
(
åå& '
Contrato
åå' /
contrato
åå0 8
)
åå8 9
{
çç 	
try
êê 
{
ëë 
	gestorSQL
íí 
.
íí 
AbrirConexion
íí '
(
íí' (
)
íí( )
;
íí) *
bool
ìì 
guardado
ìì 
=
ìì 
contratoSQLServer
ìì  1
.
ìì1 2

actualizar
ìì2 <
(
ìì< =
contrato
ìì= E
)
ììE F
;
ììF G
	gestorSQL
îî 
.
îî 
CerrarConexion
îî (
(
îî( )
)
îî) *
;
îî* +
return
ïï 
guardado
ïï 
;
ïï  
}
ññ 
catch
óó 
(
óó 
	Exception
óó 
err
óó  
)
óó  !
{
òò 
Console
öö 
.
öö 
	WriteLine
öö !
(
öö! "
err
öö" %
.
öö% &
ToString
öö& .
(
öö. /
)
öö/ 0
)
öö0 1
;
öö1 2
throw
õõ 
;
õõ 
}
úú 
}
ùù 	
public
üü 
bool
üü 
cancelarContrato
üü $
(
üü$ %
string
üü% +
id
üü, .
)
üü. /
{
†† 	
try
¢¢ 
{
££ 
	gestorSQL
§§ 
.
§§ 
AbrirConexion
§§ '
(
§§' (
)
§§( )
;
§§) *
bool
•• 
	cancelado
•• 
=
••  
contratoSQLServer
••! 2
.
••2 3
cancelar
••3 ;
(
••; <
id
••< >
)
••> ?
;
••? @
	gestorSQL
¶¶ 
.
¶¶ 
CerrarConexion
¶¶ (
(
¶¶( )
)
¶¶) *
;
¶¶* +
return
ßß 
	cancelado
ßß  
;
ßß  !
}
®® 
catch
©© 
(
©© 
	Exception
©© 
err
©©  
)
©©  !
{
™™ 
Console
¨¨ 
.
¨¨ 
	WriteLine
¨¨ !
(
¨¨! "
err
¨¨" %
.
¨¨% &
ToString
¨¨& .
(
¨¨. /
)
¨¨/ 0
)
¨¨0 1
;
¨¨1 2
throw
≠≠ 
;
≠≠ 
}
ÆÆ 
}
ØØ 	
}
±± 
}≤≤ ó
qC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Servicios\GestionarEmpleadoServicio.cs
	namespace		 	
Capa2_Aplicacion		
 
.		 
	Servicios		 $
{

 
public 

class %
GestionarEmpleadoServicio *
{ 
private 
readonly 
GestorSqlServer (
	gestorSQL) 2
;2 3
private 
readonly 
EmpleadoSqlServer *
empleadoSQL+ 6
;6 7
public %
GestionarEmpleadoServicio (
(( )
)) *
{ 	
	gestorSQL 
= 
GestorSqlServer '
.' (
getInstance( 3
(3 4
)4 5
;5 6
empleadoSQL 
= 
new 
EmpleadoSqlServer /
(/ 0
)0 1
;1 2
} 	
public 
bool 
guardarEmpleado #
(# $
Empleado$ ,
empleado- 5
)5 6
{ 	
try 
{ 
	gestorSQL 
. 
AbrirConexion '
(' (
)( )
;) *
empleadoSQL 
. 
guardar #
(# $
empleado$ ,
), -
;- .
	gestorSQL 
. 
CerrarConexion (
(( )
)) *
;* +
return 
true 
; 
} 
catch   
(   
	Exception   
err    
)    !
{!! 
Console## 
.## 
	WriteLine## !
(##! "
err##" %
.##% &
ToString##& .
(##. /
)##/ 0
)##0 1
;##1 2
throw$$ 
;$$ 
}%% 
}(( 	
public** 
Empleado**  
buscarEmpleadoPorDni** ,
(**, -
string**- 3
dni**4 7
)**7 8
{++ 	
try-- 
{.. 
	gestorSQL// 
.// 
AbrirConexion// '
(//' (
)//( )
;//) *
Empleado00 
empleado00 !
=00" #
empleadoSQL00$ /
.00/ 0 
buscarEmpleadoPorDni000 D
(00D E
dni00E H
)00H I
;00I J
	gestorSQL11 
.11 
CerrarConexion11 (
(11( )
)11) *
;11* +
return33 
empleado33 
;33  
}44 
catch55 
(55 
	Exception55 
err55  
)55  !
{66 
Console88 
.88 
	WriteLine88 !
(88! "
err88" %
.88% &
ToString88& .
(88. /
)88/ 0
)880 1
;881 2
throw99 
;99 
}:: 
}<< 	
public>> 
Empleado>> 
buscarEmpleadoPorId>> +
(>>+ ,
string>>, 2
id>>3 5
)>>5 6
{?? 	
tryAA 
{BB 
	gestorSQLDD 
.DD 
AbrirConexionDD '
(DD' (
)DD( )
;DD) *
EmpleadoEE 
empleadoEE !
=EE" #
empleadoSQLEE$ /
.EE/ 0
buscarEmpleadoPorIdEE0 C
(EEC D
idEED F
)EEF G
;EEG H
	gestorSQLFF 
.FF 
CerrarConexionFF (
(FF( )
)FF) *
;FF* +
returnHH 
empleadoHH 
;HH  
}II 
catchJJ 
(JJ 
	ExceptionJJ 
errJJ  
)JJ  !
{KK 
ConsoleLL 
.LL 
	WriteLineLL !
(LL! "
errLL" %
.LL% &
ToStringLL& .
(LL. /
)LL/ 0
)LL0 1
;LL1 2
throwMM 
;MM 
}NN 
}PP 	
}TT 
}UU  )
zC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Servicios\GestionarIncidenciaLaboralServicio.cs
	namespace		 	
Capa2_Aplicacion		
 
.		 
	Servicios		 $
{

 
public 

class .
"GestionarIncidenciaLaboralServicio 3
{ 
private 
readonly 
GestorSqlServer (
	gestorSQL) 2
;2 3
private 
readonly &
IncidenciaLaboralSqlServer 3 
incidenciaLaboralSQL4 H
;H I
private 
readonly *
GestionarPeriodoNominaServicio 7!
periodoNominaServicio8 M
;M N
public .
"GestionarIncidenciaLaboralServicio 1
(1 2
)2 3
{ 	 
incidenciaLaboralSQL  
=! "
new# &&
IncidenciaLaboralSqlServer' A
(A B
)B C
;C D!
periodoNominaServicio !
=" #
new$ '*
GestionarPeriodoNominaServicio( F
(F G
)G H
;H I
	gestorSQL 
= 
GestorSqlServer '
.' (
getInstance( 3
(3 4
)4 5
;5 6
} 	
public 
bool 
guardar 
( 
IncidenciaLaboral -

incidencia. 8
)8 9
{ 	
try 
{ 
	gestorSQL 
. 
AbrirConexion '
(' (
)( )
;) *
bool 
guardado 
=  
incidenciaLaboralSQL  4
.4 5
guardar5 <
(< =

incidencia= G
)G H
;H I
	gestorSQL   
.   
CerrarConexion   (
(  ( )
)  ) *
;  * +
return!! 
guardado!! 
;!!  
}"" 
catch## 
(## 
	Exception## 
err##  
)##  !
{$$ 
Console&& 
.&& 
	WriteLine&& !
(&&! "
err&&" %
.&&% &
ToString&&& .
(&&. /
)&&/ 0
)&&0 1
;&&1 2
throw'' 
;'' 
}(( 
})) 	
public,, 
List,, 
<,, 
IncidenciaLaboral,, %
>,,% &
obtenerPorIdPeriodo,,' :
(,,: ;
string,,; A
id,,B D
),,D E
{-- 	
try.. 
{// 
	gestorSQL00 
.00 
AbrirConexion00 '
(00' (
)00( )
;00) *
List11 
<11 
IncidenciaLaboral11 &
>11& '
lista11( -
=11. / 
incidenciaLaboralSQL110 D
.11D E
obtenerPorIdPeriodo11E X
(11X Y
id11Y [
)11[ \
;11\ ]
	gestorSQL22 
.22 
CerrarConexion22 (
(22( )
)22) *
;22* +
return33 
lista33 
;33 
}44 
catch55 
(55 
	Exception55 
err55  
)55  !
{66 
Console88 
.88 
	WriteLine88 !
(88! "
err88" %
.88% &
ToString88& .
(88. /
)88/ 0
)880 1
;881 2
throw99 
;99 
}:: 
};; 	
public== 
List== 
<== 
IncidenciaLaboral== %
>==% &%
obtenerListaPorIdContrato==' @
(==@ A
string==A G
id==H J
)==J K
{>> 	
try?? 
{@@ 
	gestorSQLAA 
.AA 
AbrirConexionAA '
(AA' (
)AA( )
;AA) *
ListBB 
<BB 
IncidenciaLaboralBB &
>BB& '
listaIncidenciasBB( 8
=BB9 : 
incidenciaLaboralSQLBB; O
.BBO P%
obtenerListaPorIdContratoBBP i
(BBi j
idBBj l
)BBl m
;BBm n
	gestorSQLCC 
.CC 
CerrarConexionCC (
(CC( )
)CC) *
;CC* +
ifEE 
(EE 
listaIncidenciasEE #
.EE# $
CountEE$ )
>EE* +
$numEE, -
)EE- .
{FF 
foreachGG 
(GG 
IncidenciaLaboralGG .
itemGG/ 3
inGG4 6
listaIncidenciasGG7 G
)GGG H
{HH 
itemJJ 
.JJ 
PeriodoJJ $
=JJ% &!
periodoNominaServicioJJ' <
.JJ< =
buscarPeriodoPorIdJJ= O
(JJO P
itemJJP T
.JJT U
PeriodoJJU \
.JJ\ ]

Periodo_idJJ] g
)JJg h
;JJh i
}LL 
}NN 
returnPP 
listaIncidenciasPP '
;PP' (
}QQ 
catchRR 
(RR 
	ExceptionRR 
errRR  
)RR  !
{SS 
ConsoleTT 
.TT 
	WriteLineTT !
(TT! "
errTT" %
.TT% &
ToStringTT& .
(TT. /
)TT/ 0
)TT0 1
;TT1 2
throwUU 
;UU 
}WW 
}YY 	
}\\ 
}]] ø*
vC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Servicios\GestionarPeriodoNominaServicio.cs
	namespace

 	
Capa2_Aplicacion


 
.

 
	Servicios

 $
{ 
public 

class *
GestionarPeriodoNominaServicio /
{ 
private 
readonly 
GestorSqlServer (
	gestorSQL) 2
;2 3
private 
readonly $
PeriodoDeNominaSqlServer 1
periodoNominaSQL2 B
;B C
public *
GestionarPeriodoNominaServicio -
(- .
). /
{ 	
	gestorSQL 
= 
GestorSqlServer '
.' (
getInstance( 3
(3 4
)4 5
;5 6
periodoNominaSQL 
= 
new "$
PeriodoDeNominaSqlServer# ;
(; <
)< =
;= >
} 	
public 
bool "
guardarPeriodoDeNomina *
(* +
PeriodoDeNomina+ :
periodoDeNomina; J
)J K
{ 	
try 
{ 
	gestorSQL 
. 
AbrirConexion '
(' (
)( )
;) *
periodoNominaSQL  
.  !
guardar! (
(( )
periodoDeNomina) 8
)8 9
;9 :
	gestorSQL   
.   
CerrarConexion   (
(  ( )
)  ) *
;  * +
return!! 
true!! 
;!! 
}"" 
catch## 
(## 
	Exception## 
err##  
)##  !
{$$ 
Console&& 
.&& 
	WriteLine&& !
(&&! "
err&&" %
.&&% &
ToString&&& .
(&&. /
)&&/ 0
)&&0 1
;&&1 2
throw'' 
;'' 
}(( 
}++ 	
public-- 
PeriodoDeNomina-- 
buscarPeriodoPorId-- 1
(--1 2
string--2 8
id--9 ;
)--; <
{.. 	
PeriodoDeNomina// 
periodoDeNomina// +
;//+ ,
try00 
{11 
	gestorSQL22 
.22 
AbrirConexion22 '
(22' (
)22( )
;22) *
periodoDeNomina33 
=33  !
periodoNominaSQL33" 2
.332 3
buscarPeriodoPorId333 E
(33E F
id33F H
)33H I
;33I J
	gestorSQL44 
.44 
CerrarConexion44 (
(44( )
)44) *
;44* +
return66 
periodoDeNomina66 &
;66& '
}77 
catch88 
(88 
	Exception88 
err88  
)88  !
{99 
Console;; 
.;; 
	WriteLine;; !
(;;! "
err;;" %
.;;% &
ToString;;& .
(;;. /
);;/ 0
);;0 1
;;;1 2
throw<< 
;<< 
}== 
}?? 	
publicCC 
ListCC 
<CC 
PeriodoDeNominaCC #
>CC# $$
buscarPeriodoPorIdNominaCC% =
(CC= >
NominaCC> D
nominaCCE K
)CCK L
{DD 	
tryGG 
{HH 
ListII 
<II 
PeriodoDeNominaII $
>II$ % 
listaPeriodoDeNominaII& :
;II: ;
	gestorSQLJJ 
.JJ 
AbrirConexionJJ '
(JJ' (
)JJ( )
;JJ) * 
listaPeriodoDeNominaKK $
=KK% &
periodoNominaSQLKK' 7
.KK7 8%
buscarPeriodosPorIdNominaKK8 Q
(KKQ R
nominaKKR X
)KKX Y
;KKY Z
	gestorSQLLL 
.LL 
CerrarConexionLL (
(LL( )
)LL) *
;LL* +
returnNN  
listaPeriodoDeNominaNN +
;NN+ ,
}OO 
catchPP 
(PP 
	ExceptionPP 
errPP  
)PP  !
{QQ 
ConsoleSS 
.SS 
	WriteLineSS !
(SS! "
errSS" %
.SS% &
ToStringSS& .
(SS. /
)SS/ 0
)SS0 1
;SS1 2
throwTT 
;TT 
}UU 
}ZZ 	
public\\ 
List\\ 
<\\ 
PeriodoDeNomina\\ #
>\\# $
obtenerListaPeriodo\\% 8
(\\8 9
)\\9 :
{]] 	
try^^ 
{__ 
	gestorSQL`` 
.`` 
AbrirConexion`` '
(``' (
)``( )
;``) *
Listaa 
<aa 
PeriodoDeNominaaa $
>aa$ %
listaPeriodoaa& 2
=aa3 4
periodoNominaSQLaa5 E
.aaE F
listarPeriodoaaF S
(aaS T
)aaT U
;aaU V
	gestorSQLbb 
.bb 
CerrarConexionbb (
(bb( )
)bb) *
;bb* +
returndd 
listaPeriododd #
;dd# $
}ee 
catchff 
(ff 
SqlExceptionff 
errff  #
)ff# $
{gg 
Consoleii 
.ii 
	WriteLineii !
(ii! "
errii" %
.ii% &
ToStringii& .
(ii. /
)ii/ 0
)ii0 1
;ii1 2
throwjj 
;jj 
}kk 
}ll 	
}nn 
}oo õ=
nC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa2_Aplicacion\Servicios\ProcesarNominaServicio.cs
	namespace		 	
Capa2_Aplicacion		
 
.		 
	Servicios		 $
{

 
public 

class "
ProcesarNominaServicio '
{ 
private 
readonly 
GestorSqlServer (
	gestorSql) 2
;2 3
private 
readonly 
NominaSqlServer (
	nominaSQL) 2
;2 3
private 
readonly )
GestionarBoletaDePagoServicio 6 
boletaDePagoServicio7 K
;K L
private 
readonly *
GestionarPeriodoNominaServicio 7!
periodoNominaServicio8 M
;M N
public "
ProcesarNominaServicio %
(% &
)& '
{ 	
	gestorSql 
= 
GestorSqlServer '
.' (
getInstance( 3
(3 4
)4 5
;5 6
	nominaSQL 
= 
new 
NominaSqlServer +
(+ ,
), -
;- . 
boletaDePagoServicio  
=! "
new# &)
GestionarBoletaDePagoServicio' D
(D E
)E F
;F G!
periodoNominaServicio !
=" #
new$ '*
GestionarPeriodoNominaServicio( F
(F G
)G H
;H I
} 	
public 
void 
guardar 
( 
Nomina "
nomina# )
)) *
{ 	
try   
{!! 
	gestorSql## 
.## 
AbrirConexion## '
(##' (
)##( )
;##) *
	nominaSQL$$ 
.$$ 
guardar$$ !
($$! "
nomina$$" (
)$$( )
;$$) *
	gestorSql%% 
.%% 
CerrarConexion%% (
(%%( )
)%%) *
;%%* +
foreach** 
(** 
BoletaDePago** %
boleta**& ,
in**- /
nomina**0 6
.**6 7
BoletaDePagos**7 D
)**D E
{++ 
boleta,, 
.,, 
	Boleta_id,, $
=,,% &
$str,,' ,
+,,- ."
GenerarNumeroAleatorio,,/ E
.,,E F"
ObtenerNumeroAleatorio,,F \
(,,\ ]
),,] ^
+,,_ `
DateTime,,a i
.,,i j
Now,,j m
.,,m n
Millisecond,,n y
;,,y z
boleta-- 
.-- 

Reintegros-- %
=--& '
$num--( )
;--) *
boleta.. 
... 
	Movilidad.. $
=..% &
$num..' (
;..( )
boleta// 
.// 
Otrosingresos// (
=//) *
$num//+ ,
;//, -
boleta00 
.00 
	Adelantos00 $
=00% &
$num00' (
;00( )
boleta11 
.11 
Otrosdescuentos11 *
=11+ ,
$num11- .
;11. / 
boletaDePagoServicio22 (
.22( )
guardar22) 0
(220 1
boleta221 7
)227 8
;228 9
}33 
}55 
catch66 
(66 
	Exception66 
err66  
)66  !
{77 
Console99 
.99 
	WriteLine99 !
(99! "
err99" %
.99% &
ToString99& .
(99. /
)99/ 0
)990 1
;991 2
throw:: 
;:: 
};; 
}<< 	
public?? 
void?? 
cerrar?? 
(?? 
Nomina?? !
nomina??" (
)??( )
{@@ 	
tryAA 
{BB 
	gestorSqlCC 
.CC 
AbrirConexionCC '
(CC' (
)CC( )
;CC) *
	nominaSQLDD 
.DD 
cerrarDD  
(DD  !
nominaDD! '
)DD' (
;DD( )
	gestorSqlEE 
.EE 
CerrarConexionEE (
(EE( )
)EE) *
;EE* +
}FF 
catchGG 
(GG 
	ExceptionGG 
errGG  
)GG  !
{HH 
ConsoleJJ 
.JJ 
	WriteLineJJ !
(JJ! "
errJJ" %
.JJ% &
ToStringJJ& .
(JJ. /
)JJ/ 0
)JJ0 1
;JJ1 2
throwKK 
;KK 
}LL 
}MM 	
publicPP 
voidPP 
eliminarPP 
(PP 
NominaPP #
nominaPP$ *
)PP* +
{QQ 	
tryRR 
{SS 
foreachVV 
(VV 
BoletaDePagoVV %
boletaVV& ,
inVV- /
nominaVV0 6
.VV6 7
BoletaDePagosVV7 D
)VVD E
{WW  
boletaDePagoServicioXX (
.XX( )
eliminarPorIdNominaXX) <
(XX< =
nominaXX= C
.XXC D
	Nomina_idXXD M
)XXM N
;XXN O
}YY 
	gestorSqlZZ 
.ZZ 
AbrirConexionZZ '
(ZZ' (
)ZZ( )
;ZZ) *
	nominaSQL[[ 
.[[ 
eliminar[[ "
([[" #
nomina[[# )
)[[) *
;[[* +
	gestorSql\\ 
.\\ 
CerrarConexion\\ (
(\\( )
)\\) *
;\\* +
}__ 
catch`` 
(`` 
	Exception`` 
err``  
)``  !
{aa 
Consolecc 
.cc 
	WriteLinecc !
(cc! "
errcc" %
.cc% &
ToStringcc& .
(cc. /
)cc/ 0
)cc0 1
;cc1 2
throwdd 
;dd 
}ee 
}ff 	
publichh 
Listhh 
<hh 
Nominahh 
>hh &
buscarNominaPorDescripcionhh 6
(hh6 7
stringhh7 =
descripcionhh> I
)hhI J
{ii 	
tryjj 
{kk 
	gestorSqlll 
.ll 
AbrirConexionll '
(ll' (
)ll( )
;ll) *
Listmm 
<mm 
Nominamm 
>mm 
listaNominamm (
=mm) *
	nominaSQLmm+ 4
.mm4 5 
buscarPorDescripcionmm5 I
(mmI J
descripcionmmJ U
)mmU V
;mmV W
	gestorSqlnn 
.nn 
CerrarConexionnn (
(nn( )
)nn) *
;nn* +
ifpp 
(pp 
listaNominapp 
.pp 
Countpp $
>pp% &
$numpp' (
)pp( )
{qq 
foreachrr 
(rr 
Nominarr #
nominarr$ *
inrr+ -
listaNominarr. 9
)rr9 :
{ss 
nominatt 
.tt 
BoletaDePagostt ,
=tt- . 
boletaDePagoServiciott/ C
.ttC D$
buscarBoletasPorIdNominattD \
(tt\ ]
nominatt] c
)ttc d
;ttd e
nominauu 
.uu 
Periodouu &
=uu' (!
periodoNominaServiciouu) >
.uu> ?
buscarPeriodoPorIduu? Q
(uuQ R
nominauuR X
.uuX Y
PeriodouuY `
.uu` a

Periodo_iduua k
)uuk l
;uul m
}vv 
}ww 
returnxx 
listaNominaxx "
;xx" #
}yy 
catchzz 
(zz 
	Exceptionzz 
errzz  
)zz  !
{{{ 
Console}} 
.}} 
	WriteLine}} !
(}}! "
err}}" %
.}}% &
ToString}}& .
(}}. /
)}}/ 0
)}}0 1
;}}1 2
throw~~ 
;~~ 
} 
}
ÄÄ 	
}
ÉÉ 
}ÑÑ 