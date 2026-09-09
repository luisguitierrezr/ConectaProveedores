namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PI_ITEM_SM2 (jJHLAGFd6UmvP6VcGqNAmg)
///  <code>ST_9327164801e6ab5e342b0e8e98c59312Structure</code> that represents <code>PI_ITEM_SM2</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SM2
public partial struct ST_9327164801e6ab5e342b0e8e98c59312Structure : ITypedRecord<ST_9327164801e6ab5e342b0e8e98c59312Structure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*NvJYzLQsnECRBZpxwWa8tQ");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*n1aIClI70keQK2b0DeJqTQ");
internal static readonly GlobalObjectKey IdCANTIDAD_SALIDA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*vgwv_SdVbEi+7DKeLbrXLA");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*CORGY7YWqU2pE3pt_+t45A");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Lokp0EQcfUm3F3wVOPYMew");
internal static readonly GlobalObjectKey IdPEP_EMISOR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*gnYN_D42BUmeQ6jBzTFPmw");
internal static readonly GlobalObjectKey IdPEP_RECEPTOR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*4dzWVnUDb0uq0ugSylB_cQ");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*tiovUTUhtUis9xvGP3bZ9Q");
internal static readonly GlobalObjectKey IdID_SITIO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*cE8yzZR1WUSlGBCH9YMj+g");

public int ssPOSICION_PEDIDO;

public string ssMATERIAL;

public decimal ssCANTIDAD_SALIDA;

public string ssCENTRO;

public string ssALMACEN;

public string ssPEP_EMISOR;

public string ssPEP_RECEPTOR;

public string ssTEXTO_POSICION;

public string ssID_SITIO;


public BitArray OptimizedAttributes;

public ST_9327164801e6ab5e342b0e8e98c59312Structure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = -2147483648;
ssMATERIAL = "";
ssCANTIDAD_SALIDA = -79228162514264337593543950335m;
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
ssPOSICION_PEDIDO = r.ReadInteger(index++, "PI_ITEM_SM2.POSICION_PEDIDO", 0);
ssMATERIAL = r.ReadText(index++, "PI_ITEM_SM2.MATERIAL", "");
ssCANTIDAD_SALIDA = r.ReadDecimal(index++, "PI_ITEM_SM2.CANTIDAD_SALIDA", 0.0M);
ssCENTRO = r.ReadText(index++, "PI_ITEM_SM2.CENTRO", "");
ssALMACEN = r.ReadText(index++, "PI_ITEM_SM2.ALMACEN", "");
ssPEP_EMISOR = r.ReadText(index++, "PI_ITEM_SM2.PEP_EMISOR", "");
ssPEP_RECEPTOR = r.ReadText(index++, "PI_ITEM_SM2.PEP_RECEPTOR", "");
ssTEXTO_POSICION = r.ReadText(index++, "PI_ITEM_SM2.TEXTO_POSICION", "");
ssID_SITIO = r.ReadText(index++, "PI_ITEM_SM2.ID_SITIO", "");
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
public void ReadIM(ST_9327164801e6ab5e342b0e8e98c59312Structure r) {
this = r;
}


public static bool operator == (ST_9327164801e6ab5e342b0e8e98c59312Structure a, ST_9327164801e6ab5e342b0e8e98c59312Structure b) {
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

public static bool operator != (ST_9327164801e6ab5e342b0e8e98c59312Structure a, ST_9327164801e6ab5e342b0e8e98c59312Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9327164801e6ab5e342b0e8e98c59312Structure)) return false;
return (this == (ST_9327164801e6ab5e342b0e8e98c59312Structure)o);
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


public ST_9327164801e6ab5e342b0e8e98c59312Structure Duplicate() {
ST_9327164801e6ab5e342b0e8e98c59312Structure t;
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
ssPOSICION_PEDIDO = (int) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_SALIDA = (decimal) other.AttributeGet(IdCANTIDAD_SALIDA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssPEP_EMISOR = (string) other.AttributeGet(IdPEP_EMISOR);
ssPEP_RECEPTOR = (string) other.AttributeGet(IdPEP_RECEPTOR);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
ssID_SITIO = (string) other.AttributeGet(IdID_SITIO);
}
} // ST_9327164801e6ab5e342b0e8e98c59312Structure
/// <summary>
/// RecordList type <code>PI_ITEM_SM2List</code> that represents a record list of
///  <code>PI_ITEM_SM2</code>
/// </summary>
public partial class RL_669be34b3612e89197059379653d4a04 : GenericRecordList<ST_9327164801e6ab5e342b0e8e98c59312Structure>, IEnumerable, IEnumerator {

protected override ST_9327164801e6ab5e342b0e8e98c59312Structure GetElementDefaultValue() {
return new ST_9327164801e6ab5e342b0e8e98c59312Structure();
}

public T[] ToArray<T>(Func<ST_9327164801e6ab5e342b0e8e98c59312Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_669be34b3612e89197059379653d4a04 recordList, Func<ST_9327164801e6ab5e342b0e8e98c59312Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_669be34b3612e89197059379653d4a04(ST_9327164801e6ab5e342b0e8e98c59312Structure[] array) {
  RL_669be34b3612e89197059379653d4a04 result = new RL_669be34b3612e89197059379653d4a04();
result.InnerFromArray(array);
    return result;
}

public static RL_669be34b3612e89197059379653d4a04 ToList<T>(T[] array, Func <T, ST_9327164801e6ab5e342b0e8e98c59312Structure> converter) {
  RL_669be34b3612e89197059379653d4a04 result = new RL_669be34b3612e89197059379653d4a04();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_669be34b3612e89197059379653d4a04 FromRestList<T>(RestList<T> restList, Func <T, ST_9327164801e6ab5e342b0e8e98c59312Structure> converter) {
  RL_669be34b3612e89197059379653d4a04 result = new RL_669be34b3612e89197059379653d4a04();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_669be34b3612e89197059379653d4a04() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9327164801e6ab5e342b0e8e98c59312Structure> NewList() {
return new RL_669be34b3612e89197059379653d4a04();
}


} // RL_669be34b3612e89197059379653d4a04
}

