namespace ssConectaProveedores {
/// <summary>
/// [Structure] EmailNotification (xzr_fQ1sa0O7yO3YJzmT_w)
///  <code>ST_12668886130225cd5b17c72a6562dd7cStructure</code> that represent
/// s <code>EmailNotification</code> <p>Description: Email Notification Struct.</p>
/// </summary>
// Name: EmailNotification
public partial struct ST_12668886130225cd5b17c72a6562dd7cStructure : ITypedRecord<ST_12668886130225cd5b17c72a6562dd7cStructure> {
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AnfNNKdcJUCWyRQRKXrzng");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rmCDK1q6mkigWGQAcRlXbQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ObgU050RskeF29AElxi83g");
internal static readonly GlobalObjectKey IdEmailTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*R+3Ey7oUaUCZ4OBVd86jZg");

public string ssUserId;

public string ssEmail;

public string ssName;

public string ssEmailTo;


public BitArray OptimizedAttributes;

public ST_12668886130225cd5b17c72a6562dd7cStructure() {
OptimizedAttributes = null;
ssUserId = "";
ssEmail = "";
ssName = "";
ssEmailTo = "";
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
ssUserId = r.ReadEntityReferenceText(index++, "EmailNotification.UserId", "");
ssEmail = r.ReadEmail(index++, "EmailNotification.Email", "");
ssName = r.ReadText(index++, "EmailNotification.Name", "");
ssEmailTo = r.ReadEmail(index++, "EmailNotification.EmailTo", "");
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
public void ReadIM(ST_12668886130225cd5b17c72a6562dd7cStructure r) {
this = r;
}


public static bool operator == (ST_12668886130225cd5b17c72a6562dd7cStructure a, ST_12668886130225cd5b17c72a6562dd7cStructure b) {
if (a.ssUserId != b.ssUserId) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssName != b.ssName) return false;
if (a.ssEmailTo != b.ssEmailTo) return false;
return true;
}

public static bool operator != (ST_12668886130225cd5b17c72a6562dd7cStructure a, ST_12668886130225cd5b17c72a6562dd7cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_12668886130225cd5b17c72a6562dd7cStructure)) return false;
return (this == (ST_12668886130225cd5b17c72a6562dd7cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssEmailTo.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_12668886130225cd5b17c72a6562dd7cStructure Duplicate() {
ST_12668886130225cd5b17c72a6562dd7cStructure t;
t.ssUserId = this.ssUserId;
t.ssEmail = this.ssEmail;
t.ssName = this.ssName;
t.ssEmailTo = this.ssEmailTo;
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
if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "emailto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EmailTo")) variable.Value = ssEmailTo; else variable.Optimized = true;
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
if (key == IdUserId) {
return ssUserId;
}
if (key == IdEmail) {
return ssEmail;
}
if (key == IdName) {
return ssName;
}
if (key == IdEmailTo) {
return ssEmailTo;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdEmailTo.Key.AsGuid) {
return ssEmailTo;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUserId = (string) other.AttributeGet(IdUserId);
ssEmail = (string) other.AttributeGet(IdEmail);
ssName = (string) other.AttributeGet(IdName);
ssEmailTo = (string) other.AttributeGet(IdEmailTo);
}
} // ST_12668886130225cd5b17c72a6562dd7cStructure
/// <summary>
/// RecordList type <code>EmailNotificationList</code> that represents a record list of
///  <code>EmailNotification</code>
/// </summary>
public partial class RL_39507255c499d96d2e7021755eecd9e1 : GenericRecordList<ST_12668886130225cd5b17c72a6562dd7cStructure>, IEnumerable, IEnumerator {

protected override ST_12668886130225cd5b17c72a6562dd7cStructure GetElementDefaultValue() {
return new ST_12668886130225cd5b17c72a6562dd7cStructure();
}

public T[] ToArray<T>(Func<ST_12668886130225cd5b17c72a6562dd7cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_39507255c499d96d2e7021755eecd9e1 recordList, Func<ST_12668886130225cd5b17c72a6562dd7cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_39507255c499d96d2e7021755eecd9e1(ST_12668886130225cd5b17c72a6562dd7cStructure[] array) {
  RL_39507255c499d96d2e7021755eecd9e1 result = new RL_39507255c499d96d2e7021755eecd9e1();
result.InnerFromArray(array);
    return result;
}

public static RL_39507255c499d96d2e7021755eecd9e1 ToList<T>(T[] array, Func <T, ST_12668886130225cd5b17c72a6562dd7cStructure> converter) {
  RL_39507255c499d96d2e7021755eecd9e1 result = new RL_39507255c499d96d2e7021755eecd9e1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_39507255c499d96d2e7021755eecd9e1 FromRestList<T>(RestList<T> restList, Func <T, ST_12668886130225cd5b17c72a6562dd7cStructure> converter) {
  RL_39507255c499d96d2e7021755eecd9e1 result = new RL_39507255c499d96d2e7021755eecd9e1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_39507255c499d96d2e7021755eecd9e1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_12668886130225cd5b17c72a6562dd7cStructure> NewList() {
return new RL_39507255c499d96d2e7021755eecd9e1();
}


} // RL_39507255c499d96d2e7021755eecd9e1
}

