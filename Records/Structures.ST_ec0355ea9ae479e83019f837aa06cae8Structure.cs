namespace ssConectaProveedores {
/// <summary>
/// [Structure] EmailsNotifString (LFF9BRCw+EmUdZ22TuLLVQ)
///  <code>ST_ec0355ea9ae479e83019f837aa06cae8Structure</code> that represent
/// s <code>EmailsNotifString</code> <p>Description: Emails Notification String Struct.</p>
/// </summary>
// Name: EmailsNotifString
public partial struct ST_ec0355ea9ae479e83019f837aa06cae8Structure : ITypedRecord<ST_ec0355ea9ae479e83019f837aa06cae8Structure> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*i72_krAeVEKZQk7ym33jBw");
internal static readonly GlobalObjectKey IdUserIds = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J0MoT7AuV06x6ayDLUYZzw");

public string ssValue;

public string ssUserIds;


public BitArray OptimizedAttributes;

public ST_ec0355ea9ae479e83019f837aa06cae8Structure() {
OptimizedAttributes = null;
ssValue = "";
ssUserIds = "";
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
ssValue = r.ReadText(index++, "EmailsNotifString.Value", "");
ssUserIds = r.ReadText(index++, "EmailsNotifString.UserIds", "");
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
public void ReadIM(ST_ec0355ea9ae479e83019f837aa06cae8Structure r) {
this = r;
}


public static bool operator == (ST_ec0355ea9ae479e83019f837aa06cae8Structure a, ST_ec0355ea9ae479e83019f837aa06cae8Structure b) {
if (a.ssValue != b.ssValue) return false;
if (a.ssUserIds != b.ssUserIds) return false;
return true;
}

public static bool operator != (ST_ec0355ea9ae479e83019f837aa06cae8Structure a, ST_ec0355ea9ae479e83019f837aa06cae8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ec0355ea9ae479e83019f837aa06cae8Structure)) return false;
return (this == (ST_ec0355ea9ae479e83019f837aa06cae8Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValue.GetHashCode()
 ^ ssUserIds.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ec0355ea9ae479e83019f837aa06cae8Structure Duplicate() {
ST_ec0355ea9ae479e83019f837aa06cae8Structure t;
t.ssValue = this.ssValue;
t.ssUserIds = this.ssUserIds;
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
if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
} else if (head == "userids") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserIds")) variable.Value = ssUserIds; else variable.Optimized = true;
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
if (key == IdValue) {
return ssValue;
}
if (key == IdUserIds) {
return ssUserIds;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
if (attributeKey == IdUserIds.Key.AsGuid) {
return ssUserIds;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssValue = (string) other.AttributeGet(IdValue);
ssUserIds = (string) other.AttributeGet(IdUserIds);
}
} // ST_ec0355ea9ae479e83019f837aa06cae8Structure
/// <summary>
/// RecordList type <code>EmailsNotifStringList</code> that represents a record list of
///  <code>EmailsNotifString</code>
/// </summary>
public partial class RL_51d65c75d55ba142a832c698c107fff1 : GenericRecordList<ST_ec0355ea9ae479e83019f837aa06cae8Structure>, IEnumerable, IEnumerator {

protected override ST_ec0355ea9ae479e83019f837aa06cae8Structure GetElementDefaultValue() {
return new ST_ec0355ea9ae479e83019f837aa06cae8Structure();
}

public T[] ToArray<T>(Func<ST_ec0355ea9ae479e83019f837aa06cae8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_51d65c75d55ba142a832c698c107fff1 recordList, Func<ST_ec0355ea9ae479e83019f837aa06cae8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_51d65c75d55ba142a832c698c107fff1(ST_ec0355ea9ae479e83019f837aa06cae8Structure[] array) {
  RL_51d65c75d55ba142a832c698c107fff1 result = new RL_51d65c75d55ba142a832c698c107fff1();
result.InnerFromArray(array);
    return result;
}

public static RL_51d65c75d55ba142a832c698c107fff1 ToList<T>(T[] array, Func <T, ST_ec0355ea9ae479e83019f837aa06cae8Structure> converter) {
  RL_51d65c75d55ba142a832c698c107fff1 result = new RL_51d65c75d55ba142a832c698c107fff1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_51d65c75d55ba142a832c698c107fff1 FromRestList<T>(RestList<T> restList, Func <T, ST_ec0355ea9ae479e83019f837aa06cae8Structure> converter) {
  RL_51d65c75d55ba142a832c698c107fff1 result = new RL_51d65c75d55ba142a832c698c107fff1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_51d65c75d55ba142a832c698c107fff1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ec0355ea9ae479e83019f837aa06cae8Structure> NewList() {
return new RL_51d65c75d55ba142a832c698c107fff1();
}


} // RL_51d65c75d55ba142a832c698c107fff1
}

