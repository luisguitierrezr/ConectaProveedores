namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (J9RAx_XFUUWBGuSWXBijiA)
///  <code>RC_9282d2ea82843f3ec15beba5c474f7e7</code> that represents <code>UserDetailRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserDetailRecord
public partial struct RC_9282d2ea82843f3ec15beba5c474f7e7 : ITypedRecord<RC_9282d2ea82843f3ec15beba5c474f7e7> {
internal static readonly GlobalObjectKey IdUserDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6tKCkoSCPj_BW+ulxHT35w");

public ST_3d98fcbf952bf72084dad4104cc8c43fStructure ssSTUserDetail;


public static implicit operator ST_3d98fcbf952bf72084dad4104cc8c43fStructure( RC_9282d2ea82843f3ec15beba5c474f7e7 r) {
return r.ssSTUserDetail;
}

public static implicit operator RC_9282d2ea82843f3ec15beba5c474f7e7 (ST_3d98fcbf952bf72084dad4104cc8c43fStructure r) {
RC_9282d2ea82843f3ec15beba5c474f7e7 res = new RC_9282d2ea82843f3ec15beba5c474f7e7 ();
res.ssSTUserDetail = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9282d2ea82843f3ec15beba5c474f7e7() {
OptimizedAttributes = null;
ssSTUserDetail = new ST_3d98fcbf952bf72084dad4104cc8c43fStructure();
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
    ssSTUserDetail.OptimizedAttributes = value[0];
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
ssSTUserDetail.Read( r, ref index);
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
public void ReadIM(RC_9282d2ea82843f3ec15beba5c474f7e7 r) {
this = r;
}


public static bool operator == (RC_9282d2ea82843f3ec15beba5c474f7e7 a, RC_9282d2ea82843f3ec15beba5c474f7e7 b) {
if (a.ssSTUserDetail != b.ssSTUserDetail) return false;
return true;
}

public static bool operator != (RC_9282d2ea82843f3ec15beba5c474f7e7 a, RC_9282d2ea82843f3ec15beba5c474f7e7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9282d2ea82843f3ec15beba5c474f7e7)) return false;
return (this == (RC_9282d2ea82843f3ec15beba5c474f7e7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUserDetail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUserDetail.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUserDetail.InternalRecursiveSave();
}


public RC_9282d2ea82843f3ec15beba5c474f7e7 Duplicate() {
RC_9282d2ea82843f3ec15beba5c474f7e7 t;
t.ssSTUserDetail = (ST_3d98fcbf952bf72084dad4104cc8c43fStructure)this.ssSTUserDetail.Duplicate();
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
if (head == "userdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserDetail")) variable.Value = ssSTUserDetail; else variable.Optimized = true;
variable.SetFieldName("userdetail");
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
if (key == IdUserDetail) {
return ssSTUserDetail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserDetail.Key.AsGuid) {
return ssSTUserDetail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUserDetail.FillFromOther((IRecord) other.AttributeGet(IdUserDetail));
}
} // RC_9282d2ea82843f3ec15beba5c474f7e7
/// <summary>
/// RecordList type <code>UserDetailRecordList</code> that represents a record list of
///  <code>UserDetail</code>
/// </summary>
public partial class RL_aaa640b6a8b68791fd90db20f52b0c70 : GenericRecordList<RC_9282d2ea82843f3ec15beba5c474f7e7>, IEnumerable, IEnumerator {

protected override RC_9282d2ea82843f3ec15beba5c474f7e7 GetElementDefaultValue() {
return new RC_9282d2ea82843f3ec15beba5c474f7e7();
}

public T[] ToArray<T>(Func<RC_9282d2ea82843f3ec15beba5c474f7e7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aaa640b6a8b68791fd90db20f52b0c70 recordList, Func<RC_9282d2ea82843f3ec15beba5c474f7e7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aaa640b6a8b68791fd90db20f52b0c70(RC_9282d2ea82843f3ec15beba5c474f7e7[] array) {
  RL_aaa640b6a8b68791fd90db20f52b0c70 result = new RL_aaa640b6a8b68791fd90db20f52b0c70();
result.InnerFromArray(array);
    return result;
}

public static RL_aaa640b6a8b68791fd90db20f52b0c70 ToList<T>(T[] array, Func <T, RC_9282d2ea82843f3ec15beba5c474f7e7> converter) {
  RL_aaa640b6a8b68791fd90db20f52b0c70 result = new RL_aaa640b6a8b68791fd90db20f52b0c70();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aaa640b6a8b68791fd90db20f52b0c70 FromRestList<T>(RestList<T> restList, Func <T, RC_9282d2ea82843f3ec15beba5c474f7e7> converter) {
  RL_aaa640b6a8b68791fd90db20f52b0c70 result = new RL_aaa640b6a8b68791fd90db20f52b0c70();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aaa640b6a8b68791fd90db20f52b0c70() : base() {
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
protected override OSList<RC_9282d2ea82843f3ec15beba5c474f7e7> NewList() {
return new RL_aaa640b6a8b68791fd90db20f52b0c70();
}


} // RL_aaa640b6a8b68791fd90db20f52b0c70
}

