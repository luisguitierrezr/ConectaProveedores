namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PI_ITEM_SM3 (4NwWRMYeu0GTvZp+7ckCDQ)
///  <code>ST_21ada127931bc47aabf2d9a5964b17feStructure</code> that represents <code>PI_ITEM_SM3</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SM3
public partial struct ST_21ada127931bc47aabf2d9a5964b17feStructure : ITypedRecord<ST_21ada127931bc47aabf2d9a5964b17feStructure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*NjfURbwshk2YrZVj60l1HA");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*UFMn3FthlUCfi6QfS8ZztA");
internal static readonly GlobalObjectKey IdCANTIDAD_SALIDA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*huUwiTv6WUixij2AwY7jcw");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*iL_XE1twSEmoH3EIu2K_wg");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Z2k6ZK3ltE+puoP_zX9QlQ");
internal static readonly GlobalObjectKey IdPEP_RECEPTOR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*sXMMcdH4Jk2Fr8ZIPKJbpQ");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*0Q1Nm8K2OEOsnkbvlzgDkg");
internal static readonly GlobalObjectKey IdID_SITIO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*FcfDWQ76aUO7kojqeM3dEA");

public int ssPOSICION_PEDIDO;

public string ssMATERIAL;

public decimal ssCANTIDAD_SALIDA;

public string ssCENTRO;

public string ssALMACEN;

public string ssPEP_RECEPTOR;

public string ssTEXTO_POSICION;

public string ssID_SITIO;


public BitArray OptimizedAttributes;

public ST_21ada127931bc47aabf2d9a5964b17feStructure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = -2147483648;
ssMATERIAL = "";
ssCANTIDAD_SALIDA = -79228162514264337593543950335m;
ssCENTRO = "";
ssALMACEN = "";
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
ssPOSICION_PEDIDO = r.ReadInteger(index++, "PI_ITEM_SM3.POSICION_PEDIDO", 0);
ssMATERIAL = r.ReadText(index++, "PI_ITEM_SM3.MATERIAL", "");
ssCANTIDAD_SALIDA = r.ReadDecimal(index++, "PI_ITEM_SM3.CANTIDAD_SALIDA", 0.0M);
ssCENTRO = r.ReadText(index++, "PI_ITEM_SM3.CENTRO", "");
ssALMACEN = r.ReadText(index++, "PI_ITEM_SM3.ALMACEN", "");
ssPEP_RECEPTOR = r.ReadText(index++, "PI_ITEM_SM3.PEP_RECEPTOR", "");
ssTEXTO_POSICION = r.ReadText(index++, "PI_ITEM_SM3.TEXTO_POSICION", "");
ssID_SITIO = r.ReadText(index++, "PI_ITEM_SM3.ID_SITIO", "");
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
public void ReadIM(ST_21ada127931bc47aabf2d9a5964b17feStructure r) {
this = r;
}


public static bool operator == (ST_21ada127931bc47aabf2d9a5964b17feStructure a, ST_21ada127931bc47aabf2d9a5964b17feStructure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_SALIDA != b.ssCANTIDAD_SALIDA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssPEP_RECEPTOR != b.ssPEP_RECEPTOR) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
if (a.ssID_SITIO != b.ssID_SITIO) return false;
return true;
}

public static bool operator != (ST_21ada127931bc47aabf2d9a5964b17feStructure a, ST_21ada127931bc47aabf2d9a5964b17feStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_21ada127931bc47aabf2d9a5964b17feStructure)) return false;
return (this == (ST_21ada127931bc47aabf2d9a5964b17feStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_SALIDA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
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


public ST_21ada127931bc47aabf2d9a5964b17feStructure Duplicate() {
ST_21ada127931bc47aabf2d9a5964b17feStructure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_SALIDA = this.ssCANTIDAD_SALIDA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
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
ssPOSICION_PEDIDO = (int) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_SALIDA = (decimal) other.AttributeGet(IdCANTIDAD_SALIDA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssPEP_RECEPTOR = (string) other.AttributeGet(IdPEP_RECEPTOR);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
ssID_SITIO = (string) other.AttributeGet(IdID_SITIO);
}
} // ST_21ada127931bc47aabf2d9a5964b17feStructure
/// <summary>
/// RecordList type <code>PI_ITEM_SM3List</code> that represents a record list of
///  <code>PI_ITEM_SM3</code>
/// </summary>
public partial class RL_6c5e26ef7403cc17d38ef0323d406754 : GenericRecordList<ST_21ada127931bc47aabf2d9a5964b17feStructure>, IEnumerable, IEnumerator {

protected override ST_21ada127931bc47aabf2d9a5964b17feStructure GetElementDefaultValue() {
return new ST_21ada127931bc47aabf2d9a5964b17feStructure();
}

public T[] ToArray<T>(Func<ST_21ada127931bc47aabf2d9a5964b17feStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6c5e26ef7403cc17d38ef0323d406754 recordList, Func<ST_21ada127931bc47aabf2d9a5964b17feStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6c5e26ef7403cc17d38ef0323d406754(ST_21ada127931bc47aabf2d9a5964b17feStructure[] array) {
  RL_6c5e26ef7403cc17d38ef0323d406754 result = new RL_6c5e26ef7403cc17d38ef0323d406754();
result.InnerFromArray(array);
    return result;
}

public static RL_6c5e26ef7403cc17d38ef0323d406754 ToList<T>(T[] array, Func <T, ST_21ada127931bc47aabf2d9a5964b17feStructure> converter) {
  RL_6c5e26ef7403cc17d38ef0323d406754 result = new RL_6c5e26ef7403cc17d38ef0323d406754();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6c5e26ef7403cc17d38ef0323d406754 FromRestList<T>(RestList<T> restList, Func <T, ST_21ada127931bc47aabf2d9a5964b17feStructure> converter) {
  RL_6c5e26ef7403cc17d38ef0323d406754 result = new RL_6c5e26ef7403cc17d38ef0323d406754();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6c5e26ef7403cc17d38ef0323d406754() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_21ada127931bc47aabf2d9a5964b17feStructure> NewList() {
return new RL_6c5e26ef7403cc17d38ef0323d406754();
}


} // RL_6c5e26ef7403cc17d38ef0323d406754
}

