namespace ssConectaProveedores {
/// <summary>
/// [Structure] ReassignNotificationContent (Ii0RUGW7iEutvZXohbsHXQ)
///  <code>ST_6fc999fa8f6e0055c73f2f167c4bad19Structure</code> that represent
/// s <code>ReassignNotificationContent</code> <p>Description: </p>
/// </summary>
// Name: ReassignNotificationContent
public partial struct ST_6fc999fa8f6e0055c73f2f167c4bad19Structure : ITypedRecord<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure> {
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DC6uPPxHHUuy0DVU9XAJLA");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xE1AXWouZkC9gGkz59bzyA");
internal static readonly GlobalObjectKey IdJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sTCJ45gtl0aEPKooHvz1gw");
internal static readonly GlobalObjectKey IdPhoneNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cK37crUNjU6hDhIMQjoY_A");

public string ssEmail;

public string ssName;

public string ssJobTitle;

public string ssPhoneNumber;


public BitArray OptimizedAttributes;

public ST_6fc999fa8f6e0055c73f2f167c4bad19Structure() {
OptimizedAttributes = null;
ssEmail = "";
ssName = "";
ssJobTitle = "";
ssPhoneNumber = "";
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
ssEmail = r.ReadText(index++, "ReassignNotificationContent.Email", "");
ssName = r.ReadText(index++, "ReassignNotificationContent.Name", "");
ssJobTitle = r.ReadText(index++, "ReassignNotificationContent.JobTitle", "");
ssPhoneNumber = r.ReadText(index++, "ReassignNotificationContent.PhoneNumber", "");
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
public void ReadIM(ST_6fc999fa8f6e0055c73f2f167c4bad19Structure r) {
this = r;
}


public static bool operator == (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure a, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure b) {
if (a.ssEmail != b.ssEmail) return false;
if (a.ssName != b.ssName) return false;
if (a.ssJobTitle != b.ssJobTitle) return false;
if (a.ssPhoneNumber != b.ssPhoneNumber) return false;
return true;
}

public static bool operator != (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure a, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure)) return false;
return (this == (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssJobTitle.GetHashCode()
 ^ ssPhoneNumber.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6fc999fa8f6e0055c73f2f167c4bad19Structure Duplicate() {
ST_6fc999fa8f6e0055c73f2f167c4bad19Structure t;
t.ssEmail = this.ssEmail;
t.ssName = this.ssName;
t.ssJobTitle = this.ssJobTitle;
t.ssPhoneNumber = this.ssPhoneNumber;
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
if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "jobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".JobTitle")) variable.Value = ssJobTitle; else variable.Optimized = true;
} else if (head == "phonenumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PhoneNumber")) variable.Value = ssPhoneNumber; else variable.Optimized = true;
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
if (key == IdEmail) {
return ssEmail;
}
if (key == IdName) {
return ssName;
}
if (key == IdJobTitle) {
return ssJobTitle;
}
if (key == IdPhoneNumber) {
return ssPhoneNumber;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdJobTitle.Key.AsGuid) {
return ssJobTitle;
}
if (attributeKey == IdPhoneNumber.Key.AsGuid) {
return ssPhoneNumber;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEmail = (string) other.AttributeGet(IdEmail);
ssName = (string) other.AttributeGet(IdName);
ssJobTitle = (string) other.AttributeGet(IdJobTitle);
ssPhoneNumber = (string) other.AttributeGet(IdPhoneNumber);
}
} // ST_6fc999fa8f6e0055c73f2f167c4bad19Structure
/// <summary>
/// RecordList type <code>ReassignNotificationContentList</code> that represents a record list of
///  <code>ReassignNotificationContent</code>
/// </summary>
public partial class RL_a6b609143c9c0c645f399a7dc922d203 : GenericRecordList<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure>, IEnumerable, IEnumerator {

protected override ST_6fc999fa8f6e0055c73f2f167c4bad19Structure GetElementDefaultValue() {
return new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
}

public T[] ToArray<T>(Func<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a6b609143c9c0c645f399a7dc922d203 recordList, Func<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a6b609143c9c0c645f399a7dc922d203(ST_6fc999fa8f6e0055c73f2f167c4bad19Structure[] array) {
  RL_a6b609143c9c0c645f399a7dc922d203 result = new RL_a6b609143c9c0c645f399a7dc922d203();
result.InnerFromArray(array);
    return result;
}

public static RL_a6b609143c9c0c645f399a7dc922d203 ToList<T>(T[] array, Func <T, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure> converter) {
  RL_a6b609143c9c0c645f399a7dc922d203 result = new RL_a6b609143c9c0c645f399a7dc922d203();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a6b609143c9c0c645f399a7dc922d203 FromRestList<T>(RestList<T> restList, Func <T, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure> converter) {
  RL_a6b609143c9c0c645f399a7dc922d203 result = new RL_a6b609143c9c0c645f399a7dc922d203();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a6b609143c9c0c645f399a7dc922d203() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure> NewList() {
return new RL_a6b609143c9c0c645f399a7dc922d203();
}


} // RL_a6b609143c9c0c645f399a7dc922d203
}

