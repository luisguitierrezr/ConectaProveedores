namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ItemSM_MO (+VIGNTZIkUKxvT1iArTU5Q)
///  <code>ST_67da2825930e4cc01dda17107c43d1e6Structure</code> that represents <code>ItemSM_MO</code
/// > <p>Description: ItemSM_MO</p>
/// </summary>
// Name: ItemSM_MO
public partial struct ST_67da2825930e4cc01dda17107c43d1e6Structure : ITypedRecord<ST_67da2825930e4cc01dda17107c43d1e6Structure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*3ou_1KHkT06x4CdNMMPLxw");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*J095vGH3nU645wJjJUj99w");
internal static readonly GlobalObjectKey IdCANTIDAD_SALIDA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*mq7b_OUG6k6r7mj1He5wZw");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*sHipjOBdPEqY9O2Rgu_97g");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*DktBMh+6sUGjgpAIUmjRXw");
internal static readonly GlobalObjectKey IdPEP_EMISOR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*HHI0eP70pEqOg9TmKPjNlQ");
internal static readonly GlobalObjectKey IdPEP_RECEPTOR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*pZptFtm5sEK6+ePP3Iz3UA");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*DgdCzw3q1UqddWj5J2rllA");
internal static readonly GlobalObjectKey IdID_SITIO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*1snyZ_SkikaIrY_Exf3ulw");

public string ssPOSICION_PEDIDO;

public string ssMATERIAL;

public string ssCANTIDAD_SALIDA;

public string ssCENTRO;

public string ssALMACEN;

public string ssPEP_EMISOR;

public string ssPEP_RECEPTOR;

public string ssTEXTO_POSICION;

public string ssID_SITIO;


public BitArray OptimizedAttributes;

public ST_67da2825930e4cc01dda17107c43d1e6Structure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = "";
ssMATERIAL = "";
ssCANTIDAD_SALIDA = "";
ssCENTRO = "";
ssALMACEN = "";
ssPEP_EMISOR = "";
ssPEP_RECEPTOR = "";
ssTEXTO_POSICION = "";
ssID_SITIO = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPOSICION_PEDIDO = r.ReadText(index++, "ItemSM_MO.POSICION_PEDIDO", "");
ssMATERIAL = r.ReadText(index++, "ItemSM_MO.MATERIAL", "");
ssCANTIDAD_SALIDA = r.ReadText(index++, "ItemSM_MO.CANTIDAD_SALIDA", "");
ssCENTRO = r.ReadText(index++, "ItemSM_MO.CENTRO", "");
ssALMACEN = r.ReadText(index++, "ItemSM_MO.ALMACEN", "");
ssPEP_EMISOR = r.ReadText(index++, "ItemSM_MO.PEP_EMISOR", "");
ssPEP_RECEPTOR = r.ReadText(index++, "ItemSM_MO.PEP_RECEPTOR", "");
ssTEXTO_POSICION = r.ReadText(index++, "ItemSM_MO.TEXTO_POSICION", "");
ssID_SITIO = r.ReadText(index++, "ItemSM_MO.ID_SITIO", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_67da2825930e4cc01dda17107c43d1e6Structure r) {
this = r;
}


public static bool operator == (ST_67da2825930e4cc01dda17107c43d1e6Structure a, ST_67da2825930e4cc01dda17107c43d1e6Structure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_SALIDA != b.ssCANTIDAD_SALIDA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssPEP_EMISOR != b.ssPEP_EMISOR) return false;
if (a.ssPEP_RECEPTOR != b.ssPEP_RECEPTOR) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
if (a.ssID_SITIO != b.ssID_SITIO) return false;
return true;
}

public static bool operator != (ST_67da2825930e4cc01dda17107c43d1e6Structure a, ST_67da2825930e4cc01dda17107c43d1e6Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_67da2825930e4cc01dda17107c43d1e6Structure)) return false;
return (this == (ST_67da2825930e4cc01dda17107c43d1e6Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_SALIDA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
 ^ ssPEP_EMISOR.GetHashCode()
 ^ ssPEP_RECEPTOR.GetHashCode()
 ^ ssTEXTO_POSICION.GetHashCode()
 ^ ssID_SITIO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_67da2825930e4cc01dda17107c43d1e6Structure Duplicate() {
ST_67da2825930e4cc01dda17107c43d1e6Structure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_SALIDA = this.ssCANTIDAD_SALIDA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
t.ssPEP_EMISOR = this.ssPEP_EMISOR;
t.ssPEP_RECEPTOR = this.ssPEP_RECEPTOR;
t.ssTEXTO_POSICION = this.ssTEXTO_POSICION;
t.ssID_SITIO = this.ssID_SITIO;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "posicion_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".POSICION_PEDIDO")) variable.Value = ssPOSICION_PEDIDO; else variable.Optimized = true;
} else if (head == "material") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MATERIAL")) variable.Value = ssMATERIAL; else variable.Optimized = true;
} else if (head == "cantidad_salida") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CANTIDAD_SALIDA")) variable.Value = ssCANTIDAD_SALIDA; else variable.Optimized = true;
} else if (head == "centro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO")) variable.Value = ssCENTRO; else variable.Optimized = true;
} else if (head == "almacen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALMACEN")) variable.Value = ssALMACEN; else variable.Optimized = true;
} else if (head == "pep_emisor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEP_EMISOR")) variable.Value = ssPEP_EMISOR; else variable.Optimized = true;
} else if (head == "pep_receptor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEP_RECEPTOR")) variable.Value = ssPEP_RECEPTOR; else variable.Optimized = true;
} else if (head == "texto_posicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_POSICION")) variable.Value = ssTEXTO_POSICION; else variable.Optimized = true;
} else if (head == "id_sitio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ID_SITIO")) variable.Value = ssID_SITIO; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPOSICION_PEDIDO) {
return ssPOSICION_PEDIDO;
}
if (key == IdMATERIAL) {
return ssMATERIAL;
}
if (key == IdCANTIDAD_SALIDA) {
return ssCANTIDAD_SALIDA;
}
if (key == IdCENTRO) {
return ssCENTRO;
}
if (key == IdALMACEN) {
return ssALMACEN;
}
if (key == IdPEP_EMISOR) {
return ssPEP_EMISOR;
}
if (key == IdPEP_RECEPTOR) {
return ssPEP_RECEPTOR;
}
if (key == IdTEXTO_POSICION) {
return ssTEXTO_POSICION;
}
if (key == IdID_SITIO) {
return ssID_SITIO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPOSICION_PEDIDO.Key.AsGuid) {
return ssPOSICION_PEDIDO;
}
if (attributeKey == IdMATERIAL.Key.AsGuid) {
return ssMATERIAL;
}
if (attributeKey == IdCANTIDAD_SALIDA.Key.AsGuid) {
return ssCANTIDAD_SALIDA;
}
if (attributeKey == IdCENTRO.Key.AsGuid) {
return ssCENTRO;
}
if (attributeKey == IdALMACEN.Key.AsGuid) {
return ssALMACEN;
}
if (attributeKey == IdPEP_EMISOR.Key.AsGuid) {
return ssPEP_EMISOR;
}
if (attributeKey == IdPEP_RECEPTOR.Key.AsGuid) {
return ssPEP_RECEPTOR;
}
if (attributeKey == IdTEXTO_POSICION.Key.AsGuid) {
return ssTEXTO_POSICION;
}
if (attributeKey == IdID_SITIO.Key.AsGuid) {
return ssID_SITIO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPOSICION_PEDIDO = (string) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_SALIDA = (string) other.AttributeGet(IdCANTIDAD_SALIDA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssPEP_EMISOR = (string) other.AttributeGet(IdPEP_EMISOR);
ssPEP_RECEPTOR = (string) other.AttributeGet(IdPEP_RECEPTOR);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
ssID_SITIO = (string) other.AttributeGet(IdID_SITIO);
}
} // ST_67da2825930e4cc01dda17107c43d1e6Structure
/// <summary>
/// RecordList type <code>ItemSM_MOList</code> that represents a record list of <code>ItemSM_MO</code>
/// </summary>
public partial class RL_3bcfc0997e979683ea6eaec348a88df0 : GenericRecordList<ST_67da2825930e4cc01dda17107c43d1e6Structure>, IEnumerable, IEnumerator {

protected override ST_67da2825930e4cc01dda17107c43d1e6Structure GetElementDefaultValue() {
return new ST_67da2825930e4cc01dda17107c43d1e6Structure();
}

public T[] ToArray<T>(Func<ST_67da2825930e4cc01dda17107c43d1e6Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3bcfc0997e979683ea6eaec348a88df0 recordList, Func<ST_67da2825930e4cc01dda17107c43d1e6Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3bcfc0997e979683ea6eaec348a88df0(ST_67da2825930e4cc01dda17107c43d1e6Structure[] array) {
  RL_3bcfc0997e979683ea6eaec348a88df0 result = new RL_3bcfc0997e979683ea6eaec348a88df0();
result.InnerFromArray(array);
    return result;
}

public static RL_3bcfc0997e979683ea6eaec348a88df0 ToList<T>(T[] array, Func <T, ST_67da2825930e4cc01dda17107c43d1e6Structure> converter) {
  RL_3bcfc0997e979683ea6eaec348a88df0 result = new RL_3bcfc0997e979683ea6eaec348a88df0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3bcfc0997e979683ea6eaec348a88df0 FromRestList<T>(RestList<T> restList, Func <T, ST_67da2825930e4cc01dda17107c43d1e6Structure> converter) {
  RL_3bcfc0997e979683ea6eaec348a88df0 result = new RL_3bcfc0997e979683ea6eaec348a88df0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3bcfc0997e979683ea6eaec348a88df0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_67da2825930e4cc01dda17107c43d1e6Structure> NewList() {
return new RL_3bcfc0997e979683ea6eaec348a88df0();
}


} // RL_3bcfc0997e979683ea6eaec348a88df0
}

