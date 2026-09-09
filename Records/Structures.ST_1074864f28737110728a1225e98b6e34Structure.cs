namespace ssConectaProveedores {
/// <summary>
/// [Structure] DocumentExtrationAccount (eLjHYOFkJ06Pj0fopMUwZw)
///  <code>ST_1074864f28737110728a1225e98b6e34Structure</code> that represent
/// s <code>DocumentExtrationAccount</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationAccount
public partial struct ST_1074864f28737110728a1225e98b6e34Structure : ITypedRecord<ST_1074864f28737110728a1225e98b6e34Structure> {
internal static readonly GlobalObjectKey IdCuentadeGasto = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5xQqhNd5skqewA28KNIcoQ");
internal static readonly GlobalObjectKey IdDesde = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qFppdGkQFEKZTLFcHUUJSw");
internal static readonly GlobalObjectKey IdHasta = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*t31ppTNdjE6kiIoY3+emIQ");
internal static readonly GlobalObjectKey IdSpace = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zU3sush0A0mxPgzBwAlPYw");
internal static readonly GlobalObjectKey IdCuentadeGasto2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RGQWxY2YBESfkhSSE3q4jg");
internal static readonly GlobalObjectKey IdDesde2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FD7qVkq8OEK4Fq16OVxYOQ");
internal static readonly GlobalObjectKey IdHasta2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xa6gpr86zEOOyFpos+DxqA");

public string ssCuentadeGasto;

public string ssDesde;

public string ssHasta;

public string ssSpace;

public string ssCuentadeGasto2;

public string ssDesde2;

public string ssHasta2;


public BitArray OptimizedAttributes;

public ST_1074864f28737110728a1225e98b6e34Structure() {
OptimizedAttributes = null;
ssCuentadeGasto = "";
ssDesde = "";
ssHasta = "";
ssSpace = "";
ssCuentadeGasto2 = "";
ssDesde2 = "";
ssHasta2 = "";
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
ssCuentadeGasto = r.ReadText(index++, "DocumentExtrationAccount.CuentadeGasto", "");
ssDesde = r.ReadText(index++, "DocumentExtrationAccount.Desde", "");
ssHasta = r.ReadText(index++, "DocumentExtrationAccount.Hasta", "");
ssSpace = r.ReadText(index++, "DocumentExtrationAccount.Space", "");
ssCuentadeGasto2 = r.ReadText(index++, "DocumentExtrationAccount.CuentadeGasto2", "");
ssDesde2 = r.ReadText(index++, "DocumentExtrationAccount.Desde2", "");
ssHasta2 = r.ReadText(index++, "DocumentExtrationAccount.Hasta2", "");
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
public void ReadIM(ST_1074864f28737110728a1225e98b6e34Structure r) {
this = r;
}


public static bool operator == (ST_1074864f28737110728a1225e98b6e34Structure a, ST_1074864f28737110728a1225e98b6e34Structure b) {
if (a.ssCuentadeGasto != b.ssCuentadeGasto) return false;
if (a.ssDesde != b.ssDesde) return false;
if (a.ssHasta != b.ssHasta) return false;
if (a.ssSpace != b.ssSpace) return false;
if (a.ssCuentadeGasto2 != b.ssCuentadeGasto2) return false;
if (a.ssDesde2 != b.ssDesde2) return false;
if (a.ssHasta2 != b.ssHasta2) return false;
return true;
}

public static bool operator != (ST_1074864f28737110728a1225e98b6e34Structure a, ST_1074864f28737110728a1225e98b6e34Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1074864f28737110728a1225e98b6e34Structure)) return false;
return (this == (ST_1074864f28737110728a1225e98b6e34Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCuentadeGasto.GetHashCode()
 ^ ssDesde.GetHashCode()
 ^ ssHasta.GetHashCode()
 ^ ssSpace.GetHashCode()
 ^ ssCuentadeGasto2.GetHashCode()
 ^ ssDesde2.GetHashCode()
 ^ ssHasta2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1074864f28737110728a1225e98b6e34Structure Duplicate() {
ST_1074864f28737110728a1225e98b6e34Structure t;
t.ssCuentadeGasto = this.ssCuentadeGasto;
t.ssDesde = this.ssDesde;
t.ssHasta = this.ssHasta;
t.ssSpace = this.ssSpace;
t.ssCuentadeGasto2 = this.ssCuentadeGasto2;
t.ssDesde2 = this.ssDesde2;
t.ssHasta2 = this.ssHasta2;
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
if (head == "cuentadegasto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CuentadeGasto")) variable.Value = ssCuentadeGasto; else variable.Optimized = true;
} else if (head == "desde") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desde")) variable.Value = ssDesde; else variable.Optimized = true;
} else if (head == "hasta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hasta")) variable.Value = ssHasta; else variable.Optimized = true;
} else if (head == "space") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Space")) variable.Value = ssSpace; else variable.Optimized = true;
} else if (head == "cuentadegasto2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CuentadeGasto2")) variable.Value = ssCuentadeGasto2; else variable.Optimized = true;
} else if (head == "desde2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desde2")) variable.Value = ssDesde2; else variable.Optimized = true;
} else if (head == "hasta2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hasta2")) variable.Value = ssHasta2; else variable.Optimized = true;
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
if (key == IdCuentadeGasto) {
return ssCuentadeGasto;
}
if (key == IdDesde) {
return ssDesde;
}
if (key == IdHasta) {
return ssHasta;
}
if (key == IdSpace) {
return ssSpace;
}
if (key == IdCuentadeGasto2) {
return ssCuentadeGasto2;
}
if (key == IdDesde2) {
return ssDesde2;
}
if (key == IdHasta2) {
return ssHasta2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCuentadeGasto.Key.AsGuid) {
return ssCuentadeGasto;
}
if (attributeKey == IdDesde.Key.AsGuid) {
return ssDesde;
}
if (attributeKey == IdHasta.Key.AsGuid) {
return ssHasta;
}
if (attributeKey == IdSpace.Key.AsGuid) {
return ssSpace;
}
if (attributeKey == IdCuentadeGasto2.Key.AsGuid) {
return ssCuentadeGasto2;
}
if (attributeKey == IdDesde2.Key.AsGuid) {
return ssDesde2;
}
if (attributeKey == IdHasta2.Key.AsGuid) {
return ssHasta2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCuentadeGasto = (string) other.AttributeGet(IdCuentadeGasto);
ssDesde = (string) other.AttributeGet(IdDesde);
ssHasta = (string) other.AttributeGet(IdHasta);
ssSpace = (string) other.AttributeGet(IdSpace);
ssCuentadeGasto2 = (string) other.AttributeGet(IdCuentadeGasto2);
ssDesde2 = (string) other.AttributeGet(IdDesde2);
ssHasta2 = (string) other.AttributeGet(IdHasta2);
}
} // ST_1074864f28737110728a1225e98b6e34Structure
/// <summary>
/// RecordList type <code>DocumentExtrationAccountList</code> that represents a record list of
///  <code>DocumentExtrationAccount</code>
/// </summary>
public partial class RL_045658540a3296b8584ea97a55871dac : GenericRecordList<ST_1074864f28737110728a1225e98b6e34Structure>, IEnumerable, IEnumerator {

protected override ST_1074864f28737110728a1225e98b6e34Structure GetElementDefaultValue() {
return new ST_1074864f28737110728a1225e98b6e34Structure();
}

public T[] ToArray<T>(Func<ST_1074864f28737110728a1225e98b6e34Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_045658540a3296b8584ea97a55871dac recordList, Func<ST_1074864f28737110728a1225e98b6e34Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_045658540a3296b8584ea97a55871dac(ST_1074864f28737110728a1225e98b6e34Structure[] array) {
  RL_045658540a3296b8584ea97a55871dac result = new RL_045658540a3296b8584ea97a55871dac();
result.InnerFromArray(array);
    return result;
}

public static RL_045658540a3296b8584ea97a55871dac ToList<T>(T[] array, Func <T, ST_1074864f28737110728a1225e98b6e34Structure> converter) {
  RL_045658540a3296b8584ea97a55871dac result = new RL_045658540a3296b8584ea97a55871dac();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_045658540a3296b8584ea97a55871dac FromRestList<T>(RestList<T> restList, Func <T, ST_1074864f28737110728a1225e98b6e34Structure> converter) {
  RL_045658540a3296b8584ea97a55871dac result = new RL_045658540a3296b8584ea97a55871dac();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_045658540a3296b8584ea97a55871dac() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1074864f28737110728a1225e98b6e34Structure> NewList() {
return new RL_045658540a3296b8584ea97a55871dac();
}


} // RL_045658540a3296b8584ea97a55871dac
}

