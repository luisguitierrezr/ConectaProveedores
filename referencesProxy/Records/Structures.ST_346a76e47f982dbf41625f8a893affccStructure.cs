namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] Output2 (10uQi4qVj0albOyw2BJCbg)
///  <code>ST_346a76e47f982dbf41625f8a893affccStructure</code> that represents <code>Output2</code
/// > <p>Description: Output</p>
/// </summary>
// Name: Output2
public partial struct ST_346a76e47f982dbf41625f8a893affccStructure : ITypedRecord<ST_346a76e47f982dbf41625f8a893affccStructure> {
internal static readonly GlobalObjectKey IdIsSuccess = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*lqRh628DPk2JeLAfHVHzxw");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*ooU4zDFKbkGb1urrviNITw");

public bool ssIsSuccess;

public string ssMessage;


public BitArray OptimizedAttributes;

public ST_346a76e47f982dbf41625f8a893affccStructure() {
OptimizedAttributes = null;
ssIsSuccess = false;
ssMessage = "";
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
ssIsSuccess = r.ReadBoolean(index++, "Output2.IsSuccess", false);
ssMessage = r.ReadText(index++, "Output2.Message", "");
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
public void ReadIM(ST_346a76e47f982dbf41625f8a893affccStructure r) {
this = r;
}


public static bool operator == (ST_346a76e47f982dbf41625f8a893affccStructure a, ST_346a76e47f982dbf41625f8a893affccStructure b) {
if (a.ssIsSuccess != b.ssIsSuccess) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_346a76e47f982dbf41625f8a893affccStructure a, ST_346a76e47f982dbf41625f8a893affccStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_346a76e47f982dbf41625f8a893affccStructure)) return false;
return (this == (ST_346a76e47f982dbf41625f8a893affccStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsSuccess.GetHashCode()
 ^ ssMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_346a76e47f982dbf41625f8a893affccStructure Duplicate() {
ST_346a76e47f982dbf41625f8a893affccStructure t;
t.ssIsSuccess = this.ssIsSuccess;
t.ssMessage = this.ssMessage;
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
if (head == "issuccess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSuccess")) variable.Value = ssIsSuccess; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
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
if (key == IdIsSuccess) {
return ssIsSuccess;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsSuccess.Key.AsGuid) {
return ssIsSuccess;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsSuccess = (bool) other.AttributeGet(IdIsSuccess);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_346a76e47f982dbf41625f8a893affccStructure
/// <summary>
/// RecordList type <code>Output2List</code> that represents a record list of <code>Output2</code>
/// </summary>
public partial class RL_1a20c9ef38cfc5a759a3dacdd0efebf9 : GenericRecordList<ST_346a76e47f982dbf41625f8a893affccStructure>, IEnumerable, IEnumerator {

protected override ST_346a76e47f982dbf41625f8a893affccStructure GetElementDefaultValue() {
return new ST_346a76e47f982dbf41625f8a893affccStructure();
}

public T[] ToArray<T>(Func<ST_346a76e47f982dbf41625f8a893affccStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1a20c9ef38cfc5a759a3dacdd0efebf9 recordList, Func<ST_346a76e47f982dbf41625f8a893affccStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1a20c9ef38cfc5a759a3dacdd0efebf9(ST_346a76e47f982dbf41625f8a893affccStructure[] array) {
  RL_1a20c9ef38cfc5a759a3dacdd0efebf9 result = new RL_1a20c9ef38cfc5a759a3dacdd0efebf9();
result.InnerFromArray(array);
    return result;
}

public static RL_1a20c9ef38cfc5a759a3dacdd0efebf9 ToList<T>(T[] array, Func <T, ST_346a76e47f982dbf41625f8a893affccStructure> converter) {
  RL_1a20c9ef38cfc5a759a3dacdd0efebf9 result = new RL_1a20c9ef38cfc5a759a3dacdd0efebf9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1a20c9ef38cfc5a759a3dacdd0efebf9 FromRestList<T>(RestList<T> restList, Func <T, ST_346a76e47f982dbf41625f8a893affccStructure> converter) {
  RL_1a20c9ef38cfc5a759a3dacdd0efebf9 result = new RL_1a20c9ef38cfc5a759a3dacdd0efebf9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1a20c9ef38cfc5a759a3dacdd0efebf9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_346a76e47f982dbf41625f8a893affccStructure> NewList() {
return new RL_1a20c9ef38cfc5a759a3dacdd0efebf9();
}


} // RL_1a20c9ef38cfc5a759a3dacdd0efebf9
}

