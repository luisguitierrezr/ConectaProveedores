namespace ssConectaProveedores {
/// <summary>
/// [Structure] GetOrderData_Response (BAvPyuy6LEaHZ_NnLY161w)
///  <code>ST_77e33f0a47d2ef32eb85177e44c9b70fStructure</code> that represent
/// s <code>GetOrderData_Response</code> <p>Description: GetOrderData_Response</p>
/// </summary>
// Name: GetOrderData_Response
public partial struct ST_77e33f0a47d2ef32eb85177e44c9b70fStructure : ITypedRecord<ST_77e33f0a47d2ef32eb85177e44c9b70fStructure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7_4lvGY6i0eNSO7LUlOEog");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qFBMnCNWI0C_VlXxFCcyYA");
internal static readonly GlobalObjectKey IdOrderInfo_API = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yMnur_7pkkWNSPG3BUmLLw");

public bool ssSuccess;

public string ssMessage;

public ST_1a18ac43e89b6e5649de540bf9caa846Structure ssOrderInfo_API;


public BitArray OptimizedAttributes;

public ST_77e33f0a47d2ef32eb85177e44c9b70fStructure() {
OptimizedAttributes = null;
ssSuccess = false;
ssMessage = "";
ssOrderInfo_API = new ST_1a18ac43e89b6e5649de540bf9caa846Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssOrderInfo_API.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSuccess = r.ReadBoolean(index++, "GetOrderData_Response.Success", false);
ssMessage = r.ReadText(index++, "GetOrderData_Response.Message", "");
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
public void ReadIM(ST_77e33f0a47d2ef32eb85177e44c9b70fStructure r) {
this = r;
}


public static bool operator == (ST_77e33f0a47d2ef32eb85177e44c9b70fStructure a, ST_77e33f0a47d2ef32eb85177e44c9b70fStructure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssOrderInfo_API != b.ssOrderInfo_API) return false;
return true;
}

public static bool operator != (ST_77e33f0a47d2ef32eb85177e44c9b70fStructure a, ST_77e33f0a47d2ef32eb85177e44c9b70fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_77e33f0a47d2ef32eb85177e44c9b70fStructure)) return false;
return (this == (ST_77e33f0a47d2ef32eb85177e44c9b70fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssOrderInfo_API.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssOrderInfo_API.RecursiveReset();
}

public void InternalRecursiveSave() {
ssOrderInfo_API.InternalRecursiveSave();
}


public ST_77e33f0a47d2ef32eb85177e44c9b70fStructure Duplicate() {
ST_77e33f0a47d2ef32eb85177e44c9b70fStructure t;
t.ssSuccess = this.ssSuccess;
t.ssMessage = this.ssMessage;
t.ssOrderInfo_API = (ST_1a18ac43e89b6e5649de540bf9caa846Structure)this.ssOrderInfo_API.Duplicate();
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
if (head == "success") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Success")) variable.Value = ssSuccess; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "orderinfo_api") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderInfo_API")) variable.Value = ssOrderInfo_API; else variable.Optimized = true;
variable.SetFieldName("orderinfo_api");
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
if (key == IdSuccess) {
return ssSuccess;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdOrderInfo_API) {
return ssOrderInfo_API;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdOrderInfo_API.Key.AsGuid) {
return ssOrderInfo_API;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssMessage = (string) other.AttributeGet(IdMessage);
ssOrderInfo_API.FillFromOther((IRecord) other.AttributeGet(IdOrderInfo_API));
}
} // ST_77e33f0a47d2ef32eb85177e44c9b70fStructure
/// <summary>
/// RecordList type <code>GetOrderData_ResponseList</code> that represents a record list of
///  <code>GetOrderData_Response</code>
/// </summary>
public partial class RL_07e149d5c564080f06a01c48a9c85d7b : GenericRecordList<ST_77e33f0a47d2ef32eb85177e44c9b70fStructure>, IEnumerable, IEnumerator {

protected override ST_77e33f0a47d2ef32eb85177e44c9b70fStructure GetElementDefaultValue() {
return new ST_77e33f0a47d2ef32eb85177e44c9b70fStructure();
}

public T[] ToArray<T>(Func<ST_77e33f0a47d2ef32eb85177e44c9b70fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_07e149d5c564080f06a01c48a9c85d7b recordList, Func<ST_77e33f0a47d2ef32eb85177e44c9b70fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_07e149d5c564080f06a01c48a9c85d7b(ST_77e33f0a47d2ef32eb85177e44c9b70fStructure[] array) {
  RL_07e149d5c564080f06a01c48a9c85d7b result = new RL_07e149d5c564080f06a01c48a9c85d7b();
result.InnerFromArray(array);
    return result;
}

public static RL_07e149d5c564080f06a01c48a9c85d7b ToList<T>(T[] array, Func <T, ST_77e33f0a47d2ef32eb85177e44c9b70fStructure> converter) {
  RL_07e149d5c564080f06a01c48a9c85d7b result = new RL_07e149d5c564080f06a01c48a9c85d7b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_07e149d5c564080f06a01c48a9c85d7b FromRestList<T>(RestList<T> restList, Func <T, ST_77e33f0a47d2ef32eb85177e44c9b70fStructure> converter) {
  RL_07e149d5c564080f06a01c48a9c85d7b result = new RL_07e149d5c564080f06a01c48a9c85d7b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_07e149d5c564080f06a01c48a9c85d7b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_77e33f0a47d2ef32eb85177e44c9b70fStructure> NewList() {
return new RL_07e149d5c564080f06a01c48a9c85d7b();
}


} // RL_07e149d5c564080f06a01c48a9c85d7b
}

