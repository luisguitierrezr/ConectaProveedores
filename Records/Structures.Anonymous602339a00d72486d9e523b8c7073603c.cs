namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (oDkjYHINbUieUjuMcHNgPA)
///  <code>RC_ac991ca3646258b2c6cf2ca4475c9215</code> that represent
/// s <code>MinuteDocumentTypeUpdateRecord</code> <p>Description: </p>
/// </summary>
// Name: MinuteDocumentTypeUpdateRecord
public partial struct RC_ac991ca3646258b2c6cf2ca4475c9215 : ITypedRecord<RC_ac991ca3646258b2c6cf2ca4475c9215> {
internal static readonly GlobalObjectKey IdMinuteDocumentTypeUpdate = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oxyZrGJksljGzyykR1ySFQ");

public ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure ssSTMinuteDocumentTypeUpdate;


public static implicit operator ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure( RC_ac991ca3646258b2c6cf2ca4475c9215 r) {
return r.ssSTMinuteDocumentTypeUpdate;
}

public static implicit operator RC_ac991ca3646258b2c6cf2ca4475c9215 (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure r) {
RC_ac991ca3646258b2c6cf2ca4475c9215 res = new RC_ac991ca3646258b2c6cf2ca4475c9215 ();
res.ssSTMinuteDocumentTypeUpdate = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ac991ca3646258b2c6cf2ca4475c9215() {
OptimizedAttributes = null;
ssSTMinuteDocumentTypeUpdate = new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure();
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
    ssSTMinuteDocumentTypeUpdate.OptimizedAttributes = value[0];
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
ssSTMinuteDocumentTypeUpdate.Read( r, ref index);
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
public void ReadIM(RC_ac991ca3646258b2c6cf2ca4475c9215 r) {
this = r;
}


public static bool operator == (RC_ac991ca3646258b2c6cf2ca4475c9215 a, RC_ac991ca3646258b2c6cf2ca4475c9215 b) {
if (a.ssSTMinuteDocumentTypeUpdate != b.ssSTMinuteDocumentTypeUpdate) return false;
return true;
}

public static bool operator != (RC_ac991ca3646258b2c6cf2ca4475c9215 a, RC_ac991ca3646258b2c6cf2ca4475c9215 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ac991ca3646258b2c6cf2ca4475c9215)) return false;
return (this == (RC_ac991ca3646258b2c6cf2ca4475c9215)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMinuteDocumentTypeUpdate.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMinuteDocumentTypeUpdate.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMinuteDocumentTypeUpdate.InternalRecursiveSave();
}


public RC_ac991ca3646258b2c6cf2ca4475c9215 Duplicate() {
RC_ac991ca3646258b2c6cf2ca4475c9215 t;
t.ssSTMinuteDocumentTypeUpdate = (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure)this.ssSTMinuteDocumentTypeUpdate.Duplicate();
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
if (head == "minutedocumenttypeupdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinuteDocumentTypeUpdate")) variable.Value = ssSTMinuteDocumentTypeUpdate; else variable.Optimized = true;
variable.SetFieldName("minutedocumenttypeupdate");
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
if (key == IdMinuteDocumentTypeUpdate) {
return ssSTMinuteDocumentTypeUpdate;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMinuteDocumentTypeUpdate.Key.AsGuid) {
return ssSTMinuteDocumentTypeUpdate;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMinuteDocumentTypeUpdate.FillFromOther((IRecord) other.AttributeGet(IdMinuteDocumentTypeUpdate));
}
} // RC_ac991ca3646258b2c6cf2ca4475c9215
/// <summary>
/// RecordList type <code>MinuteDocumentTypeUpdateRecordList</code> that represents a record list of
///  <code>MinuteDocumentTypeUpdate</code>
/// </summary>
public partial class RL_c6c41ffd3d6d2127f21e737d1dbf81e5 : GenericRecordList<RC_ac991ca3646258b2c6cf2ca4475c9215>, IEnumerable, IEnumerator {

protected override RC_ac991ca3646258b2c6cf2ca4475c9215 GetElementDefaultValue() {
return new RC_ac991ca3646258b2c6cf2ca4475c9215();
}

public T[] ToArray<T>(Func<RC_ac991ca3646258b2c6cf2ca4475c9215, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c6c41ffd3d6d2127f21e737d1dbf81e5 recordList, Func<RC_ac991ca3646258b2c6cf2ca4475c9215, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c6c41ffd3d6d2127f21e737d1dbf81e5(RC_ac991ca3646258b2c6cf2ca4475c9215[] array) {
  RL_c6c41ffd3d6d2127f21e737d1dbf81e5 result = new RL_c6c41ffd3d6d2127f21e737d1dbf81e5();
result.InnerFromArray(array);
    return result;
}

public static RL_c6c41ffd3d6d2127f21e737d1dbf81e5 ToList<T>(T[] array, Func <T, RC_ac991ca3646258b2c6cf2ca4475c9215> converter) {
  RL_c6c41ffd3d6d2127f21e737d1dbf81e5 result = new RL_c6c41ffd3d6d2127f21e737d1dbf81e5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c6c41ffd3d6d2127f21e737d1dbf81e5 FromRestList<T>(RestList<T> restList, Func <T, RC_ac991ca3646258b2c6cf2ca4475c9215> converter) {
  RL_c6c41ffd3d6d2127f21e737d1dbf81e5 result = new RL_c6c41ffd3d6d2127f21e737d1dbf81e5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c6c41ffd3d6d2127f21e737d1dbf81e5() : base() {
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
protected override OSList<RC_ac991ca3646258b2c6cf2ca4475c9215> NewList() {
return new RL_c6c41ffd3d6d2127f21e737d1dbf81e5();
}


} // RL_c6c41ffd3d6d2127f21e737d1dbf81e5
}

