�
XC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa3_Dominio\Entidades\Afp.cs
	namespace 	

 
. 
	Entidades !
{ 
public		 

class		 
Afp		 
{

 
public 
int 
Afp_id 
{ 
get 
;  
set! $
;$ %
}& '
public 
String 
Nombre 
{ 
get "
;" #
set$ '
;' (
}) *
public
double
Porcentajedescuento
{
get
;
set
;
}
} 
} �/
aC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa3_Dominio\Entidades\BoletaDePago.cs
	namespace 	

 
. 
	Entidades !
{ 
public		 

class		 
BoletaDePago		 
{

 
public 
String 
	Boleta_id 
{  !
get" %
;% &
set' *
;* +
}, -
public 
double 
Sueldobasico "
{# $
get% (
;( )
set* -
;- .
}/ 0
public
double
Asignacionfamiliar
{
get
;
set
;
}
public 
double 
Montoporhoraextras (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
double 

Reintegros  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
double 
	Movilidad 
{  !
get" %
;% &
set' *
;* +
}, -
public 
double 

{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
double 
Regimenpensionario (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
double  
Montoporhorasdefalta *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
double 
	Adelantos 
{  !
get" %
;% &
set' *
;* +
}, -
public 
double 
Otrosdescuentos %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
Contrato 
Contrato  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
Nomina 
Nomina 
{ 
get "
;" #
set$ '
;' (
}) *
public"" 
int"" 
CalcularTotalHoras"" %
(""% &
)""& '
{## 	
return$$ 
Nomina$$ 
.$$ 
Periodo$$ !
.$$! " 
CalcularTotalSemanas$$" 6
($$6 7
)$$7 8
*$$9 :
Contrato$$; C
.$$C D
Horasporsemana$$D R
;$$R S
}&& 	
public)) 
void))  
CalcularSueldoBasico)) (
())( )
)))) *
{** 	
this++
.++ 
Sueldobasico++ 
=++  
CalcularTotalHoras++! 3
(++3 4
)++4 5
*++6 7
Contrato++8 @
.++@ A
Pagoporhora++A L
;++L M
},, 	
public// 
void// +
CalcularMontoAsignacionFamiliar// 3
(//3 4
)//4 5
{00 	
if11 
(11 
Contrato11 
.11 #
Tieneasignacionfamiliar11 0
)110 1
{22 
this33 
.33 
Asignacionfamiliar33 '
=33( )
this33* .
.33. /
Sueldobasico33/ ;
*33< =
$num33> A
;33A B
}44 
else55 
{55 
this66 
.66 
Asignacionfamiliar66 '
=66( )
$num66* +
;66+ ,
}77 
}:: 	
public>> 
void>> '
CalcularMontoPorHorasExtras>> /
(>>/ 0
)>>0 1
{?? 	
MontoporhoraextrasAA
=AA  !
ContratoAA" *
.AA* +'
CalcularMontoPorHorasExtrasAA+ F
(AAF G
NominaAAG M
.AAM N
PeriodoAAN U
.AAU V

Periodo_idAAV `
)AA` a
;AAa b
}BB 	
publicFF 
doubleFF !
CalcularTotalIngresosFF +
(FF+ ,
)FF, -
{GG 	
returnII 
SueldobasicoII 
+II  !
AsignacionfamiliarII" 4
+II5 6
MontoporhoraextrasII7 I
+III J

ReintegrosIIK U
+IIV W
	MovilidadIIX a
+IIb c

;IIq r
}JJ 	
publicMM 
voidMM &
CalcularRegimenPensionarioMM .
(MM. /
)MM/ 0
{NN 	
RegimenpensionarioPP 
=PP  
SueldobasicoPP! -
*PP. /
(PP0 1
ContratoPP1 9
.PP9 :
AfpPP: =
.PP= >
PorcentajedescuentoPP> Q
/PPQ R
$numPPR U
)PPU V
;PPV W
}QQ 	
publicTT 
voidTT #
CalcularMontoHorasFaltaTT +
(TT+ ,
)TT, -
{UU 	 
MontoporhorasdefaltaWW  
=WW! "
ContratoWW$ ,
.WW, -#
CalcularMontoHorasFaltaWW- D
(WWD E
NominaWWE K
.WWK L
PeriodoWWL S
.WWS T

Periodo_idWWT ^
)WW^ _
;WW_ `
}XX 	
public[[ 
double[[ $
CalcularTotalRetenciones[[ .
([[. /
)[[/ 0
{\\ 	
return^^ 
Regimenpensionario^^ %
+^^& ' 
Montoporhorasdefalta^^( <
+^^= >
	Adelantos^^? H
+^^I J
Otrosdescuentos^^K Z
;^^Z [
}__ 	
publicbb 
doublebb 
CalcularNetoAPagarbb (
(bb( )
)bb) *
{cc 	
returndd !
CalcularTotalIngresosdd (
(dd( )
)dd) *
-dd+ ,$
CalcularTotalRetencionesdd- E
(ddE F
)ddF G
;ddG H
}ee 	
}gg 
}hh �\
]C:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa3_Dominio\Entidades\Contrato.cs
	namespace 	

 
. 
	Entidades !
{ 
public		 

class		 
Contrato		 
{

 
public 
String 
Contrato_id !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
Fechainicio #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public
DateTime
Fechafin
{
get
;
set
;
}
public 
bool #
Tieneasignacionfamiliar +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
int 
Horasporsemana !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
double 
Pagoporhora !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
String 
Puesto 
{ 
get "
;" #
set$ '
;' (
}) *
public 
bool 
	Cancelado 
{ 
get  #
;# $
set% (
;( )
}* +
public 
Afp 
Afp 
{ 
get 
; 
set !
;! "
}# $
public 
Empleado 
Empleado  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
List 
< 
IncidenciaLaboral %
>% &
Incidencias' 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
public 
bool 
EstaVigente 
(  
)  !
{ 	
bool 
estado 
= 
false 
;  
DateTime## 
fechaActual##  
=##! "
DateTime### +
.##+ ,
Parse##, 1
(##1 2
DateTime##2 :
.##: ;
Now##; >
.##> ?
ToShortDateString##? P
(##P Q
)##Q R
)##R S
;##S T
if%% 
(%% 
(%% 
Fechafin%% 
.%% 
	CompareTo%% #
(%%# $
fechaActual%%$ /
)%%/ 0
==%%1 3
$num%%4 5
||%%6 8
Fechafin%%9 A
.%%A B
	CompareTo%%B K
(%%K L
fechaActual%%L W
)%%W X
==%%X Z
$num%%Z [
)%%[ \
&&%%] _
!%%` a
	Cancelado%%a j
)%%j k
{&& 
estado'' 
='' 
true'' 
;'' 
}(( 
return++ 
estado++ 
;++ 
},, 	
public00 
bool00 
ValidarFechaInicio00 &
(00& '
)00' (
{11 	
bool22 
estado22 
=22 
false22 
;22  
DateTime66 
fechaActual66  
=66! "
DateTime66# +
.66+ ,
Parse66, 1
(661 2
DateTime662 :
.66: ;
Now66; >
.66> ?
ToShortDateString66? P
(66P Q
)66Q R
)66R S
;66S T
if88 
(88 
Fechainicio88 
.88 
	CompareTo88 %
(88% &
fechaActual88& 1
)881 2
==883 5
$num886 7
||888 :
Fechainicio88; F
.88F G
	CompareTo88G P
(88P Q
fechaActual88Q \
)88\ ]
==88^ `
$num88a b
)88b c
{99 
estado:: 
=:: 
true:: 
;:: 
};; 
return<< 
estado<< 
;<< 
}== 	
public@@ 
bool@@ 
ValidarFechaFin@@ #
(@@# $
)@@$ %
{AA 	
boolBB 
estadoBB 
=BB 
falseBB 
;BB  
ConsoleCC 
.CC 
	WriteLineCC 
(CC 
FechafinCC &
.CC& '
ToShortDateStringCC' 8
(CC8 9
)CC9 :
+CC; <
$strCC= A
+CCB C
FechainicioCCD O
.CCO P
ToShortDateStringCCP a
(CCa b
)CCb c
)CCc d
;CCd e
ifDD 
(DD 
FechafinDD 
.DD 
	CompareToDD !
(DD! "
FechainicioDD" -
)DD- .
==DD/ 1
$numDD2 3
)DD3 4
{EE 
ifFF 
(FF 
(FF 
FechafinFF 
.FF 
YearFF !
-FF" #
FechainicioFF$ /
.FF/ 0
YearFF0 4
==FF5 7
$numFF8 9
)FF9 :
&&FF; =
(FF? @
FechafinFF@ H
.FFH I
MonthFFI N
-FFO P
FechainicioFFQ \
.FF\ ]
MonthFF] b
)FFb c
>=FFd f
$numFFg h
)FFh i
{GG 
estadoHH 
=HH 
trueHH !
;HH! "
}II 
ifJJ 
(JJ 
FechafinJJ 
.JJ 
YearJJ  
-JJ! "
FechainicioJJ# .
.JJ. /
YearJJ/ 3
==JJ4 6
$numJJ7 8
)JJ8 9
{KK 
intLL 

=LL& '
(LL( )
$numLL) +
-LL, -
FechainicioLL. 9
.LL9 :
MonthLL: ?
)LL? @
+LLA B
FechafinLLC K
.LLK L
MonthLLL Q
;LLQ R
ifMM 
(MM 

>=MM% '
$numMM' (
&&MM* ,

<=MM; =
$numMM> @
)MM@ A
{NN 
estadoOO 
=OO  
trueOO! %
;OO% &
}PP 
}RR 
}TT 
ConsoleUU 
.UU 
	WriteLineUU 
(UU 
estadoUU $
)UU$ %
;UU% &
returnVV 
estadoVV 
;VV 
}XX 	
public]] 
bool]] !
ViladarHorasPorSemana]] )
(]]) *
)]]* +
{^^ 	
if__ 
(__ 
(__ 
Horasporsemana__ 
>=__ !
$num__" #
&&__$ &
Horasporsemana__' 5
<=__6 8
$num__9 ;
)__< =
&&__> @
Horasporsemana__A O
%__P Q
$num__R S
==__T V
$num__W X
)__X Y
{`` 
returnaa 
trueaa 
;aa 
}bb 
returncc 
falsecc 
;cc 
}dd 	
publicgg 
boolgg 
ValidarPagoPorHoragg &
(gg& '
)gg' (
{hh 	
ifii 
(ii 
Pagoporhoraii 
>=ii 
$numii  
&&ii! #
Pagoporhoraii$ /
<=ii0 2
$numii3 5
)ii5 6
{jj 
returnkk 
truekk 
;kk 
}ll 
returnnn 
falsenn 
;nn 
}oo 	
publicss 
doubless '
CalcularMontoPorHorasExtrasss 1
(ss1 2
stringss2 8

periodo_idss9 C
)ssC D
{tt 	
intuu 
totalHorasExtrasuu  
=uu! "
$numuu# $
;uu$ %
foreachvv 
(vv 
IncidenciaLaboralvv &
itemvv' +
invv, .
Incidenciasvv/ :
)vv: ;
{ww 
ifxx 
(xx 
itemxx 
.xx 
Periodoxx  
.xx  !

Periodo_idxx! +
.xx+ ,
Equalsxx, 2
(xx2 3

periodo_idxx3 =
)xx= >
)xx> ?
{yy 
totalHorasExtraszz $
+=zz% '
itemzz( ,
.zz, -
Totalhorasextraszz- =
;zz= >
}{{ 
}}} 
return 
totalHorasExtras #
*$ %
Pagoporhora& 1
;1 2
}
�� 	
public
�� 
double
��  
CalcularHorasFalta
�� (
(
��( )
string
��) /

periodo_id
��0 :
)
��: ;
{
�� 	
double
�� 
totalHorasFalta
�� "
=
��# $
$num
��% &
;
��& '
if
�� 
(
�� 
Incidencias
�� 
.
�� 
Count
�� !
>
��" #
$num
��$ %
)
��% &
{
�� 
foreach
�� 
(
�� 
IncidenciaLaboral
�� *
incidenciaLaboral
��+ <
in
��= ?
Incidencias
��@ K
)
��K L
{
�� 
if
�� 
(
�� 
incidenciaLaboral
�� )
.
��) *
Periodo
��* 1
.
��1 2

Periodo_id
��2 <
.
��< =
Equals
��= C
(
��C D

periodo_id
��D N
)
��N O
)
��O P
{
�� 
totalHorasFalta
�� '
+=
��( *
incidenciaLaboral
��+ <
.
��< =
Totalhorasdefalta
��= N
;
��N O
}
�� 
}
�� 
}
�� 
return
�� 
totalHorasFalta
�� "
;
��" #
}
�� 	
public
�� 
double
�� %
CalcularMontoHorasFalta
�� -
(
��- .
string
��. 4

periodo_id
��5 ?
)
��? @
{
�� 	
return
��  
CalcularHorasFalta
�� %
(
��% &

periodo_id
��& 0
)
��0 1
*
��2 3
Pagoporhora
��4 ?
;
��? @
}
�� 	
public
�� 
bool
�� 
ValidarContrato
�� #
(
��# $
out
��$ '
String
��( .
mensaje
��/ 6
)
��6 7
{
�� 	
mensaje
�� 
=
�� 
$str
�� =
;
��= >
bool
�� 
cumple
�� 
=
�� 
true
�� 
;
�� 
if
�� 
(
�� 
!
��  
ValidarFechaInicio
�� #
(
��# $
)
��$ %
)
��% &
{
�� 
mensaje
�� 
+=
�� 
$str
�� 9
;
��9 :
cumple
�� 
=
�� 
false
�� 
;
�� 
}
�� 
if
�� 
(
�� 
!
�� 
ValidarFechaFin
��  
(
��  !
)
��! "
)
��" #
{
�� 
mensaje
�� 
+=
�� 
$str
�� 5
;
��5 6
cumple
�� 
=
�� 
false
�� 
;
�� 
}
�� 
if
�� 
(
�� 
!
��  
ValidarPagoPorHora
�� #
(
��# $
)
��$ %
)
��% &
{
�� 
mensaje
�� 
+=
�� 
$str
�� 9
;
��9 :
cumple
�� 
=
�� 
false
�� 
;
�� 
}
�� 
if
�� 
(
�� 
!
�� #
ViladarHorasPorSemana
�� &
(
��& '
)
��' (
)
��( )
{
�� 
mensaje
�� 
+=
�� 
$str
�� :
;
��: ;
cumple
�� 
=
�� 
false
�� 
;
�� 
}
�� 
return
�� 
cumple
�� 
;
�� 
}
�� 	
}
�� 
}�� �
]C:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa3_Dominio\Entidades\Empleado.cs
	namespace 	

 
. 
	Entidades !
{ 
public		 

class		 
Empleado		 
{

 
public 
string 
Empleado_id !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
String 
Nombres 
{ 
get  #
;# $
set% (
;( )
}* +
public
String
	Apellidos
{
get
;
set
;
}
public 
String 
Dni 
{ 
get 
;  
set! $
;$ %
}& '
public 
DateTime 
Fechanacimiento '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
String 
Telefono 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
String 
Correo 
{ 
get "
;" #
set$ '
;' (
}) *
public 
String 
	Direccion 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} �
fC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa3_Dominio\Entidades\IncidenciaLaboral.cs
	namespace 	

 
. 
	Entidades !
{ 
public		 

class		 
IncidenciaLaboral		 "
{

 
public 
int 

{! "
get# &
;& '
set( +
;+ ,
}- .
public 
int 
Totalhorasdefalta $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public
int
Totalhorasextras
{
get
;
set
;
}
public 
PeriodoDeNomina 
Periodo &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
Contrato 
Contrato  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} �B
[C:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa3_Dominio\Entidades\Nomina.cs
	namespace 	

 
. 
	Entidades !
{ 
public		 

class		 
Nomina		 
{

 
public 
String 
	Nomina_id  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
DateTime 
Fecha 
{ 
get  #
;# $
set% (
;( )
}* +
public
String
Descripcion
{
get
;
set
;
}
public 
bool 
Cerrada 
{ 
get !
;! "
set# &
;& '
}( )
public 
PeriodoDeNomina 
Periodo &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
List 
< 
BoletaDePago  
>  !

{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public 
bool !
ValidarFechaContratos )
() *
)* +
{ 	
foreach 
( 
BoletaDePago !
item" &
in' )

)7 8
{ 
if 
( 
item 
. 
Contrato  
.  !
Fechafin! )
.) *
	CompareTo* 3
(3 4
Periodo4 ;
.; <
Fechainicio< G
)G H
==I K
$numL M
&&N P
!Q R
itemR V
.V W
ContratoW _
._ `
	Cancelado` i
)i j
{ 
return 
true 
;  
} 
} 
return!! 
false!! 
;!! 
}"" 	
public$$ 
bool$$ "
ValidarFechaFinPeriodo$$ *
($$* +
)$$+ ,
{%% 	
Console&& 
.&& 
	WriteLine&& 
(&& 
Periodo&& %
.&&% &
Fechafin&&& .
.&&. /
ToString&&/ 7
(&&7 8
)&&8 9
+&&: ;
$str&&< G
+&&H I
this&&J N
.&&N O
Fecha&&O T
.&&T U
ToString&&U ]
(&&] ^
)&&^ _
)&&_ `
;&&` a
if'' 
('' 
Periodo'' 
.'' 
Fechafin''  
.''  !
	CompareTo''! *
(''* +
this''+ /
.''/ 0
Fecha''0 5
)''5 6
==''7 9
-'': ;
$num''; <
)''< =
{(( 
return** 
true** 
;** 
}++ 
return,, 
false,, 
;,, 
}-- 	
public// 
bool// #
EsFactibleGenerarNomina// +
(//+ ,
)//, -
{00 	
if11 
(11 !
ValidarFechaContratos11 $
(11$ %
)11% &
&&11' )"
ValidarFechaFinPeriodo11* @
(11@ A
)11A B
)11B C
{22 
return33 
true33 
;33 
}44 
return66 
false66 
;66 
}77 	
public:: 
bool:: '
ValidarRestaFechaFinPeriodo:: /
(::/ 0
)::0 1
{;; 	
var<< 
timeSpan<< 
=<< 
Periodo<< "
.<<" #
Fechafin<<# +
-<<, -
Periodo<<. 5
.<<5 6
Fechainicio<<6 A
;<<A B
if== 
(== 
timeSpan== 
.== 
	TotalDays== "
>==# $
$num==% '
&&==( *
timeSpan==+ 3
.==3 4
	TotalDays==4 =
<==> ?
$num==@ B
)==B C
{>> 
return?? 
true?? 
;?? 
}@@ 
returnAA 
falseAA 
;AA 
}BB 	
publicGG 
boolGG )
esValidoFechaGeneracionNominaGG 1
(GG1 2
)GG2 3
{HH 	
ifJJ 
(JJ 
FechaJJ 
.JJ 
	CompareToJJ 
(JJ 
PeriodoJJ &
.JJ& '
FechafinJJ' /
)JJ/ 0
==JJ1 3
$numJJ4 5
)JJ5 6
{KK 
returnLL 
trueLL 
;LL 
}MM 
returnOO 
falseOO 
;OO 
}PP 	
publicUU 
boolUU 
TienePagosEmpleadosUU '
(UU' (
)UU( )
{VV 	
ifWW 
(WW 

.WW 
CountWW "
>WW# $
$numWW% &
)WW& '
{XX 
returnYY 
trueYY 
;YY 
}ZZ 
return\\ 
false\\ 
;\\ 
}]] 	
public`` 
double`` '
calcularTotalIngresosNomina`` 1
(``1 2
)``2 3
{aa 	
doublebb 
totalbb 
=bb 
$numbb 
;bb 
foreachdd 
(dd 
BoletaDePagodd !
boletadd" (
indd) +

)dd9 :
{ee 
totalff 
+=ff 
boletaff 
.ff  !
CalcularTotalIngresosff  5
(ff5 6
)ff6 7
;ff7 8
}gg 
returnii 
totalii 
;ii 
}kk 	
publicnn 
doublenn *
calcularTotalRetencionesNominann 4
(nn4 5
)nn5 6
{oo 	
doublepp 
totalpp 
=pp 
$numpp 
;pp 
foreachrr 
(rr 
BoletaDePagorr !
boletarr" (
inrr) +

)rr9 :
{ss 
totaltt 
+=tt 
boletatt 
.tt  $
CalcularTotalRetencionestt  8
(tt8 9
)tt9 :
;tt: ;
}uu 
returnww 
totalww 
;ww 
}yy 	
public|| 
double|| )
calcularTotalSueldoNetoNomina|| 3
(||3 4
)||4 5
{}} 	
double~~ 
total~~ 
=~~ 
$num~~ 
;~~ 
foreach
�� 
(
�� 
BoletaDePago
�� !
boleta
��" (
in
��) +

��, 9
)
��9 :
{
�� 
total
�� 
+=
�� 
boleta
�� 
.
��   
CalcularNetoAPagar
��  2
(
��2 3
)
��3 4
;
��4 5
}
�� 
return
�� 
total
�� 
;
�� 
}
�� 	
public
�� 
bool
�� 

�� !
(
��! "
out
��" %
string
��& ,
mensaje
��- 4
)
��4 5
{
�� 	
bool
�� 
cumple
�� 
=
�� 
true
�� 
;
�� 
mensaje
�� 
=
�� 
$str
�� =
;
��= >
if
�� 
(
�� 
!
�� !
TienePagosEmpleados
�� $
(
��$ %
)
��% &
)
��& '
{
�� 
mensaje
�� 
+=
�� 
$str
�� q
;
��q r
cumple
�� 
=
�� 
false
�� 
;
�� 
}
�� 
if
�� 
(
�� 
!
�� %
EsFactibleGenerarNomina
�� (
(
��( )
)
��) *
)
��* +
{
�� 
mensaje
�� 
+=
�� 
$str
�� c
;
��c d
cumple
�� 
=
�� 
false
�� 
;
�� 
}
�� 
if
�� 
(
�� 
!
�� +
esValidoFechaGeneracionNomina
�� .
(
��. /
)
��/ 0
)
��0 1
{
�� 
mensaje
�� 
+=
�� 
$str
�� e
;
��e f
cumple
�� 
=
�� 
false
�� 
;
�� 
}
�� 
return
�� 
cumple
�� 
;
�� 
}
�� 	
}
�� 
}�� �
dC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa3_Dominio\Entidades\PeriodoDeNomina.cs
	namespace 	

 
. 
	Entidades !
{ 
public		 

class		 
PeriodoDeNomina		  
{

 
public 
String 

Periodo_id  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
String 
Descripcion !
{" #
get$ '
;' (
set) ,
;, -
}. /
public
DateTime
Fechainicio
{
get
;
set
;
}
public 
DateTime 
Fechafin  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
int  
CalcularTotalSemanas '
(' (
)( )
{ 	
if 
( 
Fechafin 
. 
	CompareTo "
(" #
Fechainicio# .
). /
==0 2
$num3 4
)4 5
{ 
TimeSpan 
	diffechas "
=# $
Fechafin% -
-. /
Fechainicio0 ;
;; <
int 
dias 
= 
	diffechas $
.$ %
Days% )
;) *
return 
dias 
/ 
$num 
;  
} 
return   
$num   
;   
}!! 	
public$$ 
bool$$ 
tieneFechaFinValida$$ '
($$' (
)$$( )
{%% 	
TimeSpan&& 
	diffechas&& 
=&&  
Fechafin&&! )
-&&* +
Fechainicio&&, 7
;&&7 8
Console'' 
.'' 
	WriteLine'' 
('' 
$str'' 4
+''5 6
	diffechas''7 @
.''@ A
Days''A E
)''E F
;''F G
if(( 
((( 
	diffechas(( 
.(( 
Days(( 
>(( 
$num((  "
&&((# %
	diffechas((& /
.((/ 0
Days((0 4
<((5 6
$num((7 9
)((9 :
{)) 
return** 
true** 
;** 
}++ 
return-- 
false-- 
;-- 
}// 	
}11 
}22 �
bC:\Users\Rover\OneDrive\Documentos\GitHub\CAPS-NominaSoft\Capa3_Dominio\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 


( 
$str (
)( )
]) *
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
$str *
)* +
]+ ,
[
assembly
:

AssemblyCopyright
(
$str
)
]
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
]$$) *