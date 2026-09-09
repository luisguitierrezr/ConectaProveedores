namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KB_7Nz+EL0i_KwrTE5qJvg)
///  <code>RC_829bb09686291c68d484c26edaf70252</code> that represent
/// s <code>NotificationOutput2Record</code> <p>Description: </p>
/// </summary>
// Name: NotificationOutput2Record
public partial struct RC_829bb09686291c68d484c26edaf70252 : ITypedRecord<RC_829bb09686291c68d484c26edaf70252> {
internal static readonly GlobalObjectKey IdNotificationOutput2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lrCbgimGaBzUhMJu2vcCUg");

public ST_968b59b0d969f443f958cd852a31dcb5Structure ssSTNotificationOutput2;


public static implicit operator ST_968b59b0d969f443f958cd852a31dcb5Structure( RC_829bb09686291c68d484c26edaf70252 r) {
return r.ssSTNotificationOutput2;
}

public static implicit operator RC_829bb09686291c68d484c26edaf70252 (ST_968b59b0d969f443f958cd852a31dcb5Structure r) {
RC_829bb09686291c68d484c26edaf70252 res = new RC_829bb09686291c68d484c26edaf70252 ();
res.ssSTNotificationOutput2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_829bb09686291c68d484c26edaf70252() {
OptimizedAttributes = null;
ssSTNotificationOutput2 = new ST_968b59b0d969f443f958cd852a31dcb5Structure();
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
    ssSTNotificationOutput2.OptimizedAttributes = value[0];
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
ssSTNotificationOutput2.Read( r, ref index);
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
public void ReadIM(RC_829bb09686291c68d484c26edaf70252 r) {
this = r;
}


public static bool operator == (RC_829bb09686291c68d484c26edaf70252 a, RC_829bb09686291c68d484c26edaf70252 b) {
if (a.ssSTNotificationOutput2 != b.ssSTNotificationOutput2) return false;
return true;
}

public static bool operator != (RC_829bb09686291c68d484c26edaf70252 a, RC_829bb09686291c68d484c26edaf70252 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_829bb09686291c68d484c26edaf70252)) return false;
return (this == (RC_829bb09686291c68d484c26edaf70252)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNotificationOutput2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNotificationOutput2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNotificationOutput2.InternalRecursiveSave();
}


public RC_829bb09686291c68d484c26edaf70252 Duplicate() {
RC_829bb09686291c68d484c26edaf70252 t;
t.ssSTNotificationOutput2 = (ST_968b59b0d969f443f958cd852a31dcb5Structure)this.ssSTNotificationOutput2.Duplicate();
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
if (head == "notificationoutput2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NotificationOutput2")) variable.Value = ssSTNotificationOutput2; else variable.Optimized = true;
variable.SetFieldName("notificationoutput2");
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
if (key == IdNotificationOutput2) {
return ssSTNotificationOutput2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNotificationOutput2.Key.AsGuid) {
return ssSTNotificationOutput2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNotificationOutput2.FillFromOther((IRecord) other.AttributeGet(IdNotificationOutput2));
}
} // RC_829bb09686291c68d484c26edaf70252
/// <summary>
/// RecordList type <code>NotificationOutput2RecordList</code> that represents a record list of
///  <code>NotificationOutput2</code>
/// </summary>
public partial class RL_06e033cd345d5bfcb6fdb82c3ce868d4 : GenericRecordList<RC_829bb09686291c68d484c26edaf70252>, IEnumerable, IEnumerator {

protected override RC_829bb09686291c68d484c26edaf70252 GetElementDefaultValue() {
return new RC_829bb09686291c68d484c26edaf70252();
}

public T[] ToArray<T>(Func<RC_829bb09686291c68d484c26edaf70252, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_06e033cd345d5bfcb6fdb82c3ce868d4 recordList, Func<RC_829bb09686291c68d484c26edaf70252, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_06e033cd345d5bfcb6fdb82c3ce868d4(RC_829bb09686291c68d484c26edaf70252[] array) {
  RL_06e033cd345d5bfcb6fdb82c3ce868d4 result = new RL_06e033cd345d5bfcb6fdb82c3ce868d4();
result.InnerFromArray(array);
    return result;
}

public static RL_06e033cd345d5bfcb6fdb82c3ce868d4 ToList<T>(T[] array, Func <T, RC_829bb09686291c68d484c26edaf70252> converter) {
  RL_06e033cd345d5bfcb6fdb82c3ce868d4 result = new RL_06e033cd345d5bfcb6fdb82c3ce868d4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_06e033cd345d5bfcb6fdb82c3ce868d4 FromRestList<T>(RestList<T> restList, Func <T, RC_829bb09686291c68d484c26edaf70252> converter) {
  RL_06e033cd345d5bfcb6fdb82c3ce868d4 result = new RL_06e033cd345d5bfcb6fdb82c3ce868d4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_06e033cd345d5bfcb6fdb82c3ce868d4() : base() {
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
protected override OSList<RC_829bb09686291c68d484c26edaf70252> NewList() {
return new RL_06e033cd345d5bfcb6fdb82c3ce868d4();
}


} // RL_06e033cd345d5bfcb6fdb82c3ce868d4
}

