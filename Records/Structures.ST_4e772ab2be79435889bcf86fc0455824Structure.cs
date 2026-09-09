namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_ITEM_EM (KCG5nRFUsU+Moxp3mQcGSQ)
///  <code>ST_4e772ab2be79435889bcf86fc0455824Structure</code> that represents <code>PI_ITEM_EM</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EM
public partial struct ST_4e772ab2be79435889bcf86fc0455824Structure : ITypedRecord<ST_4e772ab2be79435889bcf86fc0455824Structure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*6VpDLd8hbkSccTyNdXMncw");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*9xrL6fmeJEeb0Qxzznmk8Q");
internal static readonly GlobalObjectKey IdCANTIDAD_ENTRADA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*kh+sNWjN_kSv6p9fGerXHw");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*c+c0npTI3k6EviPr_eTQAQ");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*rinnJbgr3EuUmA8_1ehoAQ");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*R9OvxwY9kkedCHTXB49Q7w");

public string ssPOSICION_PEDIDO;

public string ssMATERIAL;

public decimal ssCANTIDAD_ENTRADA;

public string ssCENTRO;

public string ssALMACEN;

public string ssTEXTO_POSICION;


public BitArray OptimizedAttributes;

public ST_4e772ab2be79435889bcf86fc0455824Structure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = "-2147483648";
ssMATERIAL = "";
ssCANTIDAD_ENTRADA = -79228162514264337593543950335m;
ssCENTRO = "";
ssALMACEN = "";
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
ssPOSICION_PEDIDO = r.ReadText(index++, "PI_ITEM_EM.POSICION_PEDIDO", "");
ssMATERIAL = r.ReadText(index++, "PI_ITEM_EM.MATERIAL", "");
ssCANTIDAD_ENTRADA = r.ReadDecimal(index++, "PI_ITEM_EM.CANTIDAD_ENTRADA", 0.0M);
ssCENTRO = r.ReadText(index++, "PI_ITEM_EM.CENTRO", "");
ssALMACEN = r.ReadText(index++, "PI_ITEM_EM.ALMACEN", "");
ssTEXTO_POSICION = r.ReadText(index++, "PI_ITEM_EM.TEXTO_POSICION", "");
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
public void ReadIM(ST_4e772ab2be79435889bcf86fc0455824Structure r) {
this = r;
}


public static bool operator == (ST_4e772ab2be79435889bcf86fc0455824Structure a, ST_4e772ab2be79435889bcf86fc0455824Structure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_ENTRADA != b.ssCANTIDAD_ENTRADA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
return true;
}

public static bool operator != (ST_4e772ab2be79435889bcf86fc0455824Structure a, ST_4e772ab2be79435889bcf86fc0455824Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_4e772ab2be79435889bcf86fc0455824Structure)) return false;
return (this == (ST_4e772ab2be79435889bcf86fc0455824Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_ENTRADA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
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


public ST_4e772ab2be79435889bcf86fc0455824Structure Duplicate() {
ST_4e772ab2be79435889bcf86fc0455824Structure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_ENTRADA = this.ssCANTIDAD_ENTRADA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
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
} else if (head == "cantidad_entrada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CANTIDAD_ENTRADA")) variable.Value = ssCANTIDAD_ENTRADA; else variable.Optimized = true;
} else if (head == "centro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO")) variable.Value = ssCENTRO; else variable.Optimized = true;
} else if (head == "almacen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALMACEN")) variable.Value = ssALMACEN; else variable.Optimized = true;
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
if (key == IdCANTIDAD_ENTRADA) {
return ssCANTIDAD_ENTRADA;
}
if (key == IdCENTRO) {
return ssCENTRO;
}
if (key == IdALMACEN) {
return ssALMACEN;
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
if (attributeKey == IdCANTIDAD_ENTRADA.Key.AsGuid) {
return ssCANTIDAD_ENTRADA;
}
if (attributeKey == IdCENTRO.Key.AsGuid) {
return ssCENTRO;
}
if (attributeKey == IdALMACEN.Key.AsGuid) {
return ssALMACEN;
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
ssCANTIDAD_ENTRADA = (decimal) other.AttributeGet(IdCANTIDAD_ENTRADA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
}
} // ST_4e772ab2be79435889bcf86fc0455824Structure
/// <summary>
/// RecordList type <code>PI_ITEM_EMList</code> that represents a record list of
///  <code>PI_ITEM_EM</code>
/// </summary>
public partial class RL_299977c13e39cc1952c431fa77f88689 : GenericRecordList<ST_4e772ab2be79435889bcf86fc0455824Structure>, IEnumerable, IEnumerator {

protected override ST_4e772ab2be79435889bcf86fc0455824Structure GetElementDefaultValue() {
return new ST_4e772ab2be79435889bcf86fc0455824Structure();
}

public T[] ToArray<T>(Func<ST_4e772ab2be79435889bcf86fc0455824Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_299977c13e39cc1952c431fa77f88689 recordList, Func<ST_4e772ab2be79435889bcf86fc0455824Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_299977c13e39cc1952c431fa77f88689(ST_4e772ab2be79435889bcf86fc0455824Structure[] array) {
  RL_299977c13e39cc1952c431fa77f88689 result = new RL_299977c13e39cc1952c431fa77f88689();
result.InnerFromArray(array);
    return result;
}

public static RL_299977c13e39cc1952c431fa77f88689 ToList<T>(T[] array, Func <T, ST_4e772ab2be79435889bcf86fc0455824Structure> converter) {
  RL_299977c13e39cc1952c431fa77f88689 result = new RL_299977c13e39cc1952c431fa77f88689();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_299977c13e39cc1952c431fa77f88689 FromRestList<T>(RestList<T> restList, Func <T, ST_4e772ab2be79435889bcf86fc0455824Structure> converter) {
  RL_299977c13e39cc1952c431fa77f88689 result = new RL_299977c13e39cc1952c431fa77f88689();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_299977c13e39cc1952c431fa77f88689() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_4e772ab2be79435889bcf86fc0455824Structure> NewList() {
return new RL_299977c13e39cc1952c431fa77f88689();
}


} // RL_299977c13e39cc1952c431fa77f88689
}

