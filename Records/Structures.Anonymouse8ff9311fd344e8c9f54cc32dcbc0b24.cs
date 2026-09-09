namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EZP_6DT9jE6fVMwy3LwLJA)
///  <code>RC_af7f929096d90ec76642e03604dc9f51</code> that represent
/// s <code>NotificationErrorStructRecord</code> <p>Description: </p>
/// </summary>
// Name: NotificationErrorStructRecord
public partial struct RC_af7f929096d90ec76642e03604dc9f51 : ITypedRecord<RC_af7f929096d90ec76642e03604dc9f51> {
internal static readonly GlobalObjectKey IdNotificationErrorStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kJJ_r9mWxw5mQuA2BNyfUQ");

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure ssSTNotificationErrorStruct;


public static implicit operator ST_bb4ffb4d3263f72e713312025a0e6fc7Structure( RC_af7f929096d90ec76642e03604dc9f51 r) {
return r.ssSTNotificationErrorStruct;
}

public static implicit operator RC_af7f929096d90ec76642e03604dc9f51 (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure r) {
RC_af7f929096d90ec76642e03604dc9f51 res = new RC_af7f929096d90ec76642e03604dc9f51 ();
res.ssSTNotificationErrorStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_af7f929096d90ec76642e03604dc9f51() {
OptimizedAttributes = null;
ssSTNotificationErrorStruct = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();
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
    ssSTNotificationErrorStruct.OptimizedAttributes = value[0];
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
ssSTNotificationErrorStruct.Read( r, ref index);
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
public void ReadIM(RC_af7f929096d90ec76642e03604dc9f51 r) {
this = r;
}


public static bool operator == (RC_af7f929096d90ec76642e03604dc9f51 a, RC_af7f929096d90ec76642e03604dc9f51 b) {
if (a.ssSTNotificationErrorStruct != b.ssSTNotificationErrorStruct) return false;
return true;
}

public static bool operator != (RC_af7f929096d90ec76642e03604dc9f51 a, RC_af7f929096d90ec76642e03604dc9f51 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_af7f929096d90ec76642e03604dc9f51)) return false;
return (this == (RC_af7f929096d90ec76642e03604dc9f51)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNotificationErrorStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNotificationErrorStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNotificationErrorStruct.InternalRecursiveSave();
}


public RC_af7f929096d90ec76642e03604dc9f51 Duplicate() {
RC_af7f929096d90ec76642e03604dc9f51 t;
t.ssSTNotificationErrorStruct = (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)this.ssSTNotificationErrorStruct.Duplicate();
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
if (head == "notificationerrorstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NotificationErrorStruct")) variable.Value = ssSTNotificationErrorStruct; else variable.Optimized = true;
variable.SetFieldName("notificationerrorstruct");
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
if (key == IdNotificationErrorStruct) {
return ssSTNotificationErrorStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNotificationErrorStruct.Key.AsGuid) {
return ssSTNotificationErrorStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNotificationErrorStruct.FillFromOther((IRecord) other.AttributeGet(IdNotificationErrorStruct));
}
} // RC_af7f929096d90ec76642e03604dc9f51
/// <summary>
/// RecordList type <code>NotificationErrorStructRecordList</code> that represents a record list of
///  <code>NotificationErrorStruct</code>
/// </summary>
public partial class RL_87e4b9e9bf646627fdcc260f1da36bfe : GenericRecordList<RC_af7f929096d90ec76642e03604dc9f51>, IEnumerable, IEnumerator {

protected override RC_af7f929096d90ec76642e03604dc9f51 GetElementDefaultValue() {
return new RC_af7f929096d90ec76642e03604dc9f51();
}

public T[] ToArray<T>(Func<RC_af7f929096d90ec76642e03604dc9f51, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_87e4b9e9bf646627fdcc260f1da36bfe recordList, Func<RC_af7f929096d90ec76642e03604dc9f51, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_87e4b9e9bf646627fdcc260f1da36bfe(RC_af7f929096d90ec76642e03604dc9f51[] array) {
  RL_87e4b9e9bf646627fdcc260f1da36bfe result = new RL_87e4b9e9bf646627fdcc260f1da36bfe();
result.InnerFromArray(array);
    return result;
}

public static RL_87e4b9e9bf646627fdcc260f1da36bfe ToList<T>(T[] array, Func <T, RC_af7f929096d90ec76642e03604dc9f51> converter) {
  RL_87e4b9e9bf646627fdcc260f1da36bfe result = new RL_87e4b9e9bf646627fdcc260f1da36bfe();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_87e4b9e9bf646627fdcc260f1da36bfe FromRestList<T>(RestList<T> restList, Func <T, RC_af7f929096d90ec76642e03604dc9f51> converter) {
  RL_87e4b9e9bf646627fdcc260f1da36bfe result = new RL_87e4b9e9bf646627fdcc260f1da36bfe();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_87e4b9e9bf646627fdcc260f1da36bfe() : base() {
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
protected override OSList<RC_af7f929096d90ec76642e03604dc9f51> NewList() {
return new RL_87e4b9e9bf646627fdcc260f1da36bfe();
}


} // RL_87e4b9e9bf646627fdcc260f1da36bfe
}

