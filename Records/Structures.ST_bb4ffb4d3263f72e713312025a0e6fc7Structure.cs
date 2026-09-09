namespace ssConectaProveedores {
/// <summary>
/// [Structure] NotificationErrorStruct (FSY7DvtqEUmGEkW3l+HoCg)
///  <code>ST_bb4ffb4d3263f72e713312025a0e6fc7Structure</code> that represent
/// s <code>NotificationErrorStruct</code> <p>Description: NotificationError</p>
/// </summary>
// Name: NotificationErrorStruct
public partial struct ST_bb4ffb4d3263f72e713312025a0e6fc7Structure : ITypedRecord<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure> {
internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EeX8nCzjfk2eBbC7zY_+Pg");
internal static readonly GlobalObjectKey IdApprovalErrorList = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hKIL9Fw7f0GBqjHKhST+EQ");

public string ssTitle;

public RL_b07a2c599719eeabf4cf87e53c7dda78 ssApprovalErrorList;


public BitArray OptimizedAttributes;

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure() {
OptimizedAttributes = null;
ssTitle = "";
ssApprovalErrorList = new RL_b07a2c599719eeabf4cf87e53c7dda78();
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
ssTitle = r.ReadText(index++, "NotificationErrorStruct.Title", "");
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
public void ReadIM(ST_bb4ffb4d3263f72e713312025a0e6fc7Structure r) {
this = r;
}


public static bool operator == (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure a, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure b) {
if (a.ssTitle != b.ssTitle) return false;
if (a.ssApprovalErrorList != b.ssApprovalErrorList) return false;
return true;
}

public static bool operator != (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure a, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)) return false;
return (this == (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTitle.GetHashCode()
 ^ ssApprovalErrorList.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssApprovalErrorList.RecursiveReset();
}

public void InternalRecursiveSave() {
ssApprovalErrorList.InternalRecursiveSave();
}


public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure Duplicate() {
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure t;
t.ssTitle = this.ssTitle;
t.ssApprovalErrorList = (RL_b07a2c599719eeabf4cf87e53c7dda78)this.ssApprovalErrorList.Duplicate();
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
if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
} else if (head == "approvalerrorlist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalErrorList")) variable.Value = ssApprovalErrorList; else variable.Optimized = true;
variable.SetFieldName("approvalerrorlist");
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
if (key == IdTitle) {
return ssTitle;
}
if (key == IdApprovalErrorList) {
return ssApprovalErrorList;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTitle.Key.AsGuid) {
return ssTitle;
}
if (attributeKey == IdApprovalErrorList.Key.AsGuid) {
return ssApprovalErrorList;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssTitle = (string) other.AttributeGet(IdTitle);
ssApprovalErrorList = new RL_b07a2c599719eeabf4cf87e53c7dda78();
ssApprovalErrorList.FillFromOther((IOSList) other.AttributeGet(IdApprovalErrorList));
}
} // ST_bb4ffb4d3263f72e713312025a0e6fc7Structure
/// <summary>
/// RecordList type <code>NotificationErrorStructList</code> that represents a record list of
///  <code>NotificationErrorStruct</code>
/// </summary>
public partial class RL_e736dbca2a169af89cbae1deb88d2ad1 : GenericRecordList<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure>, IEnumerable, IEnumerator {

protected override ST_bb4ffb4d3263f72e713312025a0e6fc7Structure GetElementDefaultValue() {
return new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();
}

public T[] ToArray<T>(Func<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e736dbca2a169af89cbae1deb88d2ad1 recordList, Func<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e736dbca2a169af89cbae1deb88d2ad1(ST_bb4ffb4d3263f72e713312025a0e6fc7Structure[] array) {
  RL_e736dbca2a169af89cbae1deb88d2ad1 result = new RL_e736dbca2a169af89cbae1deb88d2ad1();
result.InnerFromArray(array);
    return result;
}

public static RL_e736dbca2a169af89cbae1deb88d2ad1 ToList<T>(T[] array, Func <T, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure> converter) {
  RL_e736dbca2a169af89cbae1deb88d2ad1 result = new RL_e736dbca2a169af89cbae1deb88d2ad1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e736dbca2a169af89cbae1deb88d2ad1 FromRestList<T>(RestList<T> restList, Func <T, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure> converter) {
  RL_e736dbca2a169af89cbae1deb88d2ad1 result = new RL_e736dbca2a169af89cbae1deb88d2ad1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e736dbca2a169af89cbae1deb88d2ad1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure> NewList() {
return new RL_e736dbca2a169af89cbae1deb88d2ad1();
}


} // RL_e736dbca2a169af89cbae1deb88d2ad1
}

