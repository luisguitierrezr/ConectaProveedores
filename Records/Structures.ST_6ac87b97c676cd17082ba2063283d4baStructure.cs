namespace ssConectaProveedores {
/// <summary>
/// [Structure] NotificationContentStruct (8lE4qYQM9USPD2frPdE+Pg)
///  <code>ST_6ac87b97c676cd17082ba2063283d4baStructure</code> that represent
/// s <code>NotificationContentStruct</code> <p>Description: NotificationContent</p>
/// </summary>
// Name: NotificationContentStruct
public partial struct ST_6ac87b97c676cd17082ba2063283d4baStructure : ITypedRecord<ST_6ac87b97c676cd17082ba2063283d4baStructure> {
internal static readonly GlobalObjectKey IdNrOfRecordsAffected = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6EHKTRURLUSbm4Hh2yQsJA");
internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ny+2B8z+kEG9kQY4G+Y2wQ");
internal static readonly GlobalObjectKey IdNrOfRecordsSuccessful = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*67izoo+29Uu6sTZjDLKHCg");
internal static readonly GlobalObjectKey IdNrOfRecordsUnsuccessful = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AfBdUZYJg0KsR4nfXEXcJQ");

public int ssNrOfRecordsAffected;

public string ssTitle;

public int ssNrOfRecordsSuccessful;

public int ssNrOfRecordsUnsuccessful;


public BitArray OptimizedAttributes;

public ST_6ac87b97c676cd17082ba2063283d4baStructure() {
OptimizedAttributes = null;
ssNrOfRecordsAffected = 0;
ssTitle = "";
ssNrOfRecordsSuccessful = 0;
ssNrOfRecordsUnsuccessful = 0;
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
ssNrOfRecordsAffected = r.ReadInteger(index++, "NotificationContentStruct.NrOfRecordsAffected", 0);
ssTitle = r.ReadText(index++, "NotificationContentStruct.Title", "");
ssNrOfRecordsSuccessful = r.ReadInteger(index++, "NotificationContentStruct.NrOfRecordsSuccessful", 0);
ssNrOfRecordsUnsuccessful = r.ReadInteger(index++, "NotificationContentStruct.NrOfRecordsUnsuccessful", 0);
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
public void ReadIM(ST_6ac87b97c676cd17082ba2063283d4baStructure r) {
this = r;
}


public static bool operator == (ST_6ac87b97c676cd17082ba2063283d4baStructure a, ST_6ac87b97c676cd17082ba2063283d4baStructure b) {
if (a.ssNrOfRecordsAffected != b.ssNrOfRecordsAffected) return false;
if (a.ssTitle != b.ssTitle) return false;
if (a.ssNrOfRecordsSuccessful != b.ssNrOfRecordsSuccessful) return false;
if (a.ssNrOfRecordsUnsuccessful != b.ssNrOfRecordsUnsuccessful) return false;
return true;
}

public static bool operator != (ST_6ac87b97c676cd17082ba2063283d4baStructure a, ST_6ac87b97c676cd17082ba2063283d4baStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6ac87b97c676cd17082ba2063283d4baStructure)) return false;
return (this == (ST_6ac87b97c676cd17082ba2063283d4baStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssNrOfRecordsAffected.GetHashCode()
 ^ ssTitle.GetHashCode()
 ^ ssNrOfRecordsSuccessful.GetHashCode()
 ^ ssNrOfRecordsUnsuccessful.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6ac87b97c676cd17082ba2063283d4baStructure Duplicate() {
ST_6ac87b97c676cd17082ba2063283d4baStructure t;
t.ssNrOfRecordsAffected = this.ssNrOfRecordsAffected;
t.ssTitle = this.ssTitle;
t.ssNrOfRecordsSuccessful = this.ssNrOfRecordsSuccessful;
t.ssNrOfRecordsUnsuccessful = this.ssNrOfRecordsUnsuccessful;
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
if (head == "nrofrecordsaffected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NrOfRecordsAffected")) variable.Value = ssNrOfRecordsAffected; else variable.Optimized = true;
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
} else if (head == "nrofrecordssuccessful") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NrOfRecordsSuccessful")) variable.Value = ssNrOfRecordsSuccessful; else variable.Optimized = true;
} else if (head == "nrofrecordsunsuccessful") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NrOfRecordsUnsuccessful")) variable.Value = ssNrOfRecordsUnsuccessful; else variable.Optimized = true;
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
if (key == IdNrOfRecordsAffected) {
return ssNrOfRecordsAffected;
}
if (key == IdTitle) {
return ssTitle;
}
if (key == IdNrOfRecordsSuccessful) {
return ssNrOfRecordsSuccessful;
}
if (key == IdNrOfRecordsUnsuccessful) {
return ssNrOfRecordsUnsuccessful;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNrOfRecordsAffected.Key.AsGuid) {
return ssNrOfRecordsAffected;
}
if (attributeKey == IdTitle.Key.AsGuid) {
return ssTitle;
}
if (attributeKey == IdNrOfRecordsSuccessful.Key.AsGuid) {
return ssNrOfRecordsSuccessful;
}
if (attributeKey == IdNrOfRecordsUnsuccessful.Key.AsGuid) {
return ssNrOfRecordsUnsuccessful;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssNrOfRecordsAffected = (int) other.AttributeGet(IdNrOfRecordsAffected);
ssTitle = (string) other.AttributeGet(IdTitle);
ssNrOfRecordsSuccessful = (int) other.AttributeGet(IdNrOfRecordsSuccessful);
ssNrOfRecordsUnsuccessful = (int) other.AttributeGet(IdNrOfRecordsUnsuccessful);
}
} // ST_6ac87b97c676cd17082ba2063283d4baStructure
/// <summary>
/// RecordList type <code>NotificationContentStructList</code> that represents a record list of
///  <code>NotificationContentStruct</code>
/// </summary>
public partial class RL_8d72c8a1ebd6a7a8bd6cf689f27984c9 : GenericRecordList<ST_6ac87b97c676cd17082ba2063283d4baStructure>, IEnumerable, IEnumerator {

protected override ST_6ac87b97c676cd17082ba2063283d4baStructure GetElementDefaultValue() {
return new ST_6ac87b97c676cd17082ba2063283d4baStructure();
}

public T[] ToArray<T>(Func<ST_6ac87b97c676cd17082ba2063283d4baStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8d72c8a1ebd6a7a8bd6cf689f27984c9 recordList, Func<ST_6ac87b97c676cd17082ba2063283d4baStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8d72c8a1ebd6a7a8bd6cf689f27984c9(ST_6ac87b97c676cd17082ba2063283d4baStructure[] array) {
  RL_8d72c8a1ebd6a7a8bd6cf689f27984c9 result = new RL_8d72c8a1ebd6a7a8bd6cf689f27984c9();
result.InnerFromArray(array);
    return result;
}

public static RL_8d72c8a1ebd6a7a8bd6cf689f27984c9 ToList<T>(T[] array, Func <T, ST_6ac87b97c676cd17082ba2063283d4baStructure> converter) {
  RL_8d72c8a1ebd6a7a8bd6cf689f27984c9 result = new RL_8d72c8a1ebd6a7a8bd6cf689f27984c9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8d72c8a1ebd6a7a8bd6cf689f27984c9 FromRestList<T>(RestList<T> restList, Func <T, ST_6ac87b97c676cd17082ba2063283d4baStructure> converter) {
  RL_8d72c8a1ebd6a7a8bd6cf689f27984c9 result = new RL_8d72c8a1ebd6a7a8bd6cf689f27984c9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8d72c8a1ebd6a7a8bd6cf689f27984c9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6ac87b97c676cd17082ba2063283d4baStructure> NewList() {
return new RL_8d72c8a1ebd6a7a8bd6cf689f27984c9();
}


} // RL_8d72c8a1ebd6a7a8bd6cf689f27984c9
}

