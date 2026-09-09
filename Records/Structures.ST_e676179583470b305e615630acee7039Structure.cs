namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_ITEM_SM (uo3LS6JKsUugxztQnn37Gg)
///  <code>ST_e676179583470b305e615630acee7039Structure</code> that represents <code>PI_ITEM_SM</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SM
public partial struct ST_e676179583470b305e615630acee7039Structure : ITypedRecord<ST_e676179583470b305e615630acee7039Structure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*WzPOmjAD0EOB6fgHitYvyw");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*R283BA3m9USpWcnj9NeZoQ");
internal static readonly GlobalObjectKey IdCANTIDAD_SALIDA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*RwoOoZOZ0E6o9pDXDA3kbw");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*ojZVJ7WZDEa8G3lEHt2kZQ");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*D+8aIr3uZUibrRa_BU4UEQ");
internal static readonly GlobalObjectKey IdCUENTA_DE_MAYOR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*FJbLCzInnkCKcaI87FD2Dg");
internal static readonly GlobalObjectKey IdCENTRO_DE_COSTO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*KWD6XHOpD0q5xsEsRKi1RQ");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*0EVnG97wIkG0TRUJcpFUig");

public string ssPOSICION_PEDIDO;

public string ssMATERIAL;

public decimal ssCANTIDAD_SALIDA;

public string ssCENTRO;

public string ssALMACEN;

public string ssCUENTA_DE_MAYOR;

public string ssCENTRO_DE_COSTO;

public string ssTEXTO_POSICION;


public BitArray OptimizedAttributes;

public ST_e676179583470b305e615630acee7039Structure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = "-2147483648";
ssMATERIAL = "";
ssCANTIDAD_SALIDA = -79228162514264337593543950335m;
ssCENTRO = "";
ssALMACEN = "";
ssCUENTA_DE_MAYOR = "";
ssCENTRO_DE_COSTO = "";
ssTEXTO_POSICION = "";
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
ssPOSICION_PEDIDO = r.ReadText(index++, "PI_ITEM_SM.POSICION_PEDIDO", "");
ssMATERIAL = r.ReadText(index++, "PI_ITEM_SM.MATERIAL", "");
ssCANTIDAD_SALIDA = r.ReadDecimal(index++, "PI_ITEM_SM.CANTIDAD_SALIDA", 0.0M);
ssCENTRO = r.ReadText(index++, "PI_ITEM_SM.CENTRO", "");
ssALMACEN = r.ReadText(index++, "PI_ITEM_SM.ALMACEN", "");
ssCUENTA_DE_MAYOR = r.ReadText(index++, "PI_ITEM_SM.CUENTA_DE_MAYOR", "");
ssCENTRO_DE_COSTO = r.ReadText(index++, "PI_ITEM_SM.CENTRO_DE_COSTO", "");
ssTEXTO_POSICION = r.ReadText(index++, "PI_ITEM_SM.TEXTO_POSICION", "");
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
public void ReadIM(ST_e676179583470b305e615630acee7039Structure r) {
this = r;
}


public static bool operator == (ST_e676179583470b305e615630acee7039Structure a, ST_e676179583470b305e615630acee7039Structure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_SALIDA != b.ssCANTIDAD_SALIDA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssCUENTA_DE_MAYOR != b.ssCUENTA_DE_MAYOR) return false;
if (a.ssCENTRO_DE_COSTO != b.ssCENTRO_DE_COSTO) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
return true;
}

public static bool operator != (ST_e676179583470b305e615630acee7039Structure a, ST_e676179583470b305e615630acee7039Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e676179583470b305e615630acee7039Structure)) return false;
return (this == (ST_e676179583470b305e615630acee7039Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_SALIDA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
 ^ ssCUENTA_DE_MAYOR.GetHashCode()
 ^ ssCENTRO_DE_COSTO.GetHashCode()
 ^ ssTEXTO_POSICION.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e676179583470b305e615630acee7039Structure Duplicate() {
ST_e676179583470b305e615630acee7039Structure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_SALIDA = this.ssCANTIDAD_SALIDA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
t.ssCUENTA_DE_MAYOR = this.ssCUENTA_DE_MAYOR;
t.ssCENTRO_DE_COSTO = this.ssCENTRO_DE_COSTO;
t.ssTEXTO_POSICION = this.ssTEXTO_POSICION;
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
} else if (head == "cuenta_de_mayor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CUENTA_DE_MAYOR")) variable.Value = ssCUENTA_DE_MAYOR; else variable.Optimized = true;
} else if (head == "centro_de_costo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO_DE_COSTO")) variable.Value = ssCENTRO_DE_COSTO; else variable.Optimized = true;
} else if (head == "texto_posicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_POSICION")) variable.Value = ssTEXTO_POSICION; else variable.Optimized = true;
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
if (key == IdCUENTA_DE_MAYOR) {
return ssCUENTA_DE_MAYOR;
}
if (key == IdCENTRO_DE_COSTO) {
return ssCENTRO_DE_COSTO;
}
if (key == IdTEXTO_POSICION) {
return ssTEXTO_POSICION;
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
if (attributeKey == IdCUENTA_DE_MAYOR.Key.AsGuid) {
return ssCUENTA_DE_MAYOR;
}
if (attributeKey == IdCENTRO_DE_COSTO.Key.AsGuid) {
return ssCENTRO_DE_COSTO;
}
if (attributeKey == IdTEXTO_POSICION.Key.AsGuid) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPOSICION_PEDIDO = (string) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_SALIDA = (decimal) other.AttributeGet(IdCANTIDAD_SALIDA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssCUENTA_DE_MAYOR = (string) other.AttributeGet(IdCUENTA_DE_MAYOR);
ssCENTRO_DE_COSTO = (string) other.AttributeGet(IdCENTRO_DE_COSTO);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
}
} // ST_e676179583470b305e615630acee7039Structure
/// <summary>
/// RecordList type <code>PI_ITEM_SMList</code> that represents a record list of
///  <code>PI_ITEM_SM</code>
/// </summary>
public partial class RL_6c0520d55ae99ffd7c336b769881d282 : GenericRecordList<ST_e676179583470b305e615630acee7039Structure>, IEnumerable, IEnumerator {

protected override ST_e676179583470b305e615630acee7039Structure GetElementDefaultValue() {
return new ST_e676179583470b305e615630acee7039Structure();
}

public T[] ToArray<T>(Func<ST_e676179583470b305e615630acee7039Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6c0520d55ae99ffd7c336b769881d282 recordList, Func<ST_e676179583470b305e615630acee7039Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6c0520d55ae99ffd7c336b769881d282(ST_e676179583470b305e615630acee7039Structure[] array) {
  RL_6c0520d55ae99ffd7c336b769881d282 result = new RL_6c0520d55ae99ffd7c336b769881d282();
result.InnerFromArray(array);
    return result;
}

public static RL_6c0520d55ae99ffd7c336b769881d282 ToList<T>(T[] array, Func <T, ST_e676179583470b305e615630acee7039Structure> converter) {
  RL_6c0520d55ae99ffd7c336b769881d282 result = new RL_6c0520d55ae99ffd7c336b769881d282();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6c0520d55ae99ffd7c336b769881d282 FromRestList<T>(RestList<T> restList, Func <T, ST_e676179583470b305e615630acee7039Structure> converter) {
  RL_6c0520d55ae99ffd7c336b769881d282 result = new RL_6c0520d55ae99ffd7c336b769881d282();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6c0520d55ae99ffd7c336b769881d282() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e676179583470b305e615630acee7039Structure> NewList() {
return new RL_6c0520d55ae99ffd7c336b769881d282();
}


} // RL_6c0520d55ae99ffd7c336b769881d282
}

