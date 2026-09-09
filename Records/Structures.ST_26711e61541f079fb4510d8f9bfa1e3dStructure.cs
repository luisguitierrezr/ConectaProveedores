namespace ssConectaProveedores {
/// <summary>
/// [Structure] RecordCreatedUpdatedLogStruct (VDTpierWZkKRv__yb0WVIQ)
///  <code>ST_26711e61541f079fb4510d8f9bfa1e3dStructure</code> that represent
/// s <code>RecordCreatedUpdatedLogStruct</code> <p>Description: Record Created Updated Log.</p>
/// </summary>
// Name: RecordCreatedUpdatedLogStruct
public partial struct ST_26711e61541f079fb4510d8f9bfa1e3dStructure : ITypedRecord<ST_26711e61541f079fb4510d8f9bfa1e3dStructure> {
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6VlE9ea7q0m4sMZ6k7+_lQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*biYPeQoBXEqlZ5NwO+8eiw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0evvm6FA70Gw0fdDTW4_lQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RrxvYIBaMU+vxy8yvQg7cA");

public string ssCreatedBy;

public DateTime ssCreatedOn;

public string ssUpdatedBy;

public DateTime ssUpdatedOn;


public BitArray OptimizedAttributes;

public ST_26711e61541f079fb4510d8f9bfa1e3dStructure() {
OptimizedAttributes = null;
ssCreatedBy = "";
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssUpdatedBy = "";
ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssCreatedBy = r.ReadText(index++, "RecordCreatedUpdatedLogStruct.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "RecordCreatedUpdatedLogStruct.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadText(index++, "RecordCreatedUpdatedLogStruct.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "RecordCreatedUpdatedLogStruct.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_26711e61541f079fb4510d8f9bfa1e3dStructure r) {
this = r;
}


public static bool operator == (ST_26711e61541f079fb4510d8f9bfa1e3dStructure a, ST_26711e61541f079fb4510d8f9bfa1e3dStructure b) {
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (ST_26711e61541f079fb4510d8f9bfa1e3dStructure a, ST_26711e61541f079fb4510d8f9bfa1e3dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_26711e61541f079fb4510d8f9bfa1e3dStructure)) return false;
return (this == (ST_26711e61541f079fb4510d8f9bfa1e3dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_26711e61541f079fb4510d8f9bfa1e3dStructure Duplicate() {
ST_26711e61541f079fb4510d8f9bfa1e3dStructure t;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedOn = this.ssCreatedOn;
t.ssUpdatedBy = this.ssUpdatedBy;
t.ssUpdatedOn = this.ssUpdatedOn;
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
if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
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
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
}
} // ST_26711e61541f079fb4510d8f9bfa1e3dStructure
/// <summary>
/// RecordList type <code>RecordCreatedUpdatedLogStructList</code> that represents a record list of
///  <code>RecordCreatedUpdatedLogStruct</code>
/// </summary>
public partial class RL_886962dd0c63b0d3f8f17627f6490be9 : GenericRecordList<ST_26711e61541f079fb4510d8f9bfa1e3dStructure>, IEnumerable, IEnumerator {

protected override ST_26711e61541f079fb4510d8f9bfa1e3dStructure GetElementDefaultValue() {
return new ST_26711e61541f079fb4510d8f9bfa1e3dStructure();
}

public T[] ToArray<T>(Func<ST_26711e61541f079fb4510d8f9bfa1e3dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_886962dd0c63b0d3f8f17627f6490be9 recordList, Func<ST_26711e61541f079fb4510d8f9bfa1e3dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_886962dd0c63b0d3f8f17627f6490be9(ST_26711e61541f079fb4510d8f9bfa1e3dStructure[] array) {
  RL_886962dd0c63b0d3f8f17627f6490be9 result = new RL_886962dd0c63b0d3f8f17627f6490be9();
result.InnerFromArray(array);
    return result;
}

public static RL_886962dd0c63b0d3f8f17627f6490be9 ToList<T>(T[] array, Func <T, ST_26711e61541f079fb4510d8f9bfa1e3dStructure> converter) {
  RL_886962dd0c63b0d3f8f17627f6490be9 result = new RL_886962dd0c63b0d3f8f17627f6490be9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_886962dd0c63b0d3f8f17627f6490be9 FromRestList<T>(RestList<T> restList, Func <T, ST_26711e61541f079fb4510d8f9bfa1e3dStructure> converter) {
  RL_886962dd0c63b0d3f8f17627f6490be9 result = new RL_886962dd0c63b0d3f8f17627f6490be9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_886962dd0c63b0d3f8f17627f6490be9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_26711e61541f079fb4510d8f9bfa1e3dStructure> NewList() {
return new RL_886962dd0c63b0d3f8f17627f6490be9();
}


} // RL_886962dd0c63b0d3f8f17627f6490be9
}

