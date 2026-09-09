namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (RVYVeYHNU0iwa2Z0Uy9OwA)
///  <code>RC_816307516ffd7bb138a54e5a7369bd0c</code> that represent
/// s <code>NotificationContentStructRecord</code> <p>Description: </p>
/// </summary>
// Name: NotificationContentStructRecord
public partial struct RC_816307516ffd7bb138a54e5a7369bd0c : ITypedRecord<RC_816307516ffd7bb138a54e5a7369bd0c> {
internal static readonly GlobalObjectKey IdNotificationContentStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UQdjgf1vsXs4pU5ac2m9DA");

public ST_6ac87b97c676cd17082ba2063283d4baStructure ssSTNotificationContentStruct;


public static implicit operator ST_6ac87b97c676cd17082ba2063283d4baStructure( RC_816307516ffd7bb138a54e5a7369bd0c r) {
return r.ssSTNotificationContentStruct;
}

public static implicit operator RC_816307516ffd7bb138a54e5a7369bd0c (ST_6ac87b97c676cd17082ba2063283d4baStructure r) {
RC_816307516ffd7bb138a54e5a7369bd0c res = new RC_816307516ffd7bb138a54e5a7369bd0c ();
res.ssSTNotificationContentStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_816307516ffd7bb138a54e5a7369bd0c() {
OptimizedAttributes = null;
ssSTNotificationContentStruct = new ST_6ac87b97c676cd17082ba2063283d4baStructure();
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
    ssSTNotificationContentStruct.OptimizedAttributes = value[0];
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
ssSTNotificationContentStruct.Read( r, ref index);
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
public void ReadIM(RC_816307516ffd7bb138a54e5a7369bd0c r) {
this = r;
}


public static bool operator == (RC_816307516ffd7bb138a54e5a7369bd0c a, RC_816307516ffd7bb138a54e5a7369bd0c b) {
if (a.ssSTNotificationContentStruct != b.ssSTNotificationContentStruct) return false;
return true;
}

public static bool operator != (RC_816307516ffd7bb138a54e5a7369bd0c a, RC_816307516ffd7bb138a54e5a7369bd0c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_816307516ffd7bb138a54e5a7369bd0c)) return false;
return (this == (RC_816307516ffd7bb138a54e5a7369bd0c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNotificationContentStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNotificationContentStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNotificationContentStruct.InternalRecursiveSave();
}


public RC_816307516ffd7bb138a54e5a7369bd0c Duplicate() {
RC_816307516ffd7bb138a54e5a7369bd0c t;
t.ssSTNotificationContentStruct = (ST_6ac87b97c676cd17082ba2063283d4baStructure)this.ssSTNotificationContentStruct.Duplicate();
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
if (head == "notificationcontentstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NotificationContentStruct")) variable.Value = ssSTNotificationContentStruct; else variable.Optimized = true;
variable.SetFieldName("notificationcontentstruct");
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
if (key == IdNotificationContentStruct) {
return ssSTNotificationContentStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNotificationContentStruct.Key.AsGuid) {
return ssSTNotificationContentStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNotificationContentStruct.FillFromOther((IRecord) other.AttributeGet(IdNotificationContentStruct));
}
} // RC_816307516ffd7bb138a54e5a7369bd0c
/// <summary>
/// RecordList type <code>NotificationContentStructRecordList</code> that represents a record list of
///  <code>NotificationContentStruct</code>
/// </summary>
public partial class RL_f028064e25cc8e9aba046c9167209fa5 : GenericRecordList<RC_816307516ffd7bb138a54e5a7369bd0c>, IEnumerable, IEnumerator {

protected override RC_816307516ffd7bb138a54e5a7369bd0c GetElementDefaultValue() {
return new RC_816307516ffd7bb138a54e5a7369bd0c();
}

public T[] ToArray<T>(Func<RC_816307516ffd7bb138a54e5a7369bd0c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f028064e25cc8e9aba046c9167209fa5 recordList, Func<RC_816307516ffd7bb138a54e5a7369bd0c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f028064e25cc8e9aba046c9167209fa5(RC_816307516ffd7bb138a54e5a7369bd0c[] array) {
  RL_f028064e25cc8e9aba046c9167209fa5 result = new RL_f028064e25cc8e9aba046c9167209fa5();
result.InnerFromArray(array);
    return result;
}

public static RL_f028064e25cc8e9aba046c9167209fa5 ToList<T>(T[] array, Func <T, RC_816307516ffd7bb138a54e5a7369bd0c> converter) {
  RL_f028064e25cc8e9aba046c9167209fa5 result = new RL_f028064e25cc8e9aba046c9167209fa5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f028064e25cc8e9aba046c9167209fa5 FromRestList<T>(RestList<T> restList, Func <T, RC_816307516ffd7bb138a54e5a7369bd0c> converter) {
  RL_f028064e25cc8e9aba046c9167209fa5 result = new RL_f028064e25cc8e9aba046c9167209fa5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f028064e25cc8e9aba046c9167209fa5() : base() {
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
protected override OSList<RC_816307516ffd7bb138a54e5a7369bd0c> NewList() {
return new RL_f028064e25cc8e9aba046c9167209fa5();
}


} // RL_f028064e25cc8e9aba046c9167209fa5
}

