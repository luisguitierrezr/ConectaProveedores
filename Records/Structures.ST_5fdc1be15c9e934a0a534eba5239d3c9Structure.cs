namespace ssConectaProveedores {
/// <summary>
/// [Structure] ExcelOrderLogToExport (AfRF_BFAB0eFSeiCgXSckA)
///  <code>ST_5fdc1be15c9e934a0a534eba5239d3c9Structure</code> that represent
/// s <code>ExcelOrderLogToExport</code> <p>Description: Excel Log To Export Struct.</p>
/// </summary>
// Name: ExcelOrderLogToExport
public partial struct ST_5fdc1be15c9e934a0a534eba5239d3c9Structure : ITypedRecord<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure> {
internal static readonly GlobalObjectKey IdOrderName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*c_SZH_hbM0enMRX_x61X3Q");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FLvORo3PA0G9+TBHbnR6_A");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cUejW8AZfk+79ifwEJT9pQ");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*t71E5xK5kUyUKEDrAYW14A");

public string ssOrderName;

public string ssCreatedBy;

public DateTime ssCreatedOn;

public string ssMessage;


public BitArray OptimizedAttributes;

public ST_5fdc1be15c9e934a0a534eba5239d3c9Structure() {
OptimizedAttributes = null;
ssOrderName = "";
ssCreatedBy = "";
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMessage = "";
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
ssOrderName = r.ReadText(index++, "ExcelOrderLogToExport.OrderName", "");
ssCreatedBy = r.ReadText(index++, "ExcelOrderLogToExport.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "ExcelOrderLogToExport.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMessage = r.ReadText(index++, "ExcelOrderLogToExport.Message", "");
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
public void ReadIM(ST_5fdc1be15c9e934a0a534eba5239d3c9Structure r) {
this = r;
}


public static bool operator == (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure a, ST_5fdc1be15c9e934a0a534eba5239d3c9Structure b) {
if (a.ssOrderName != b.ssOrderName) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure a, ST_5fdc1be15c9e934a0a534eba5239d3c9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure)) return false;
return (this == (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderName.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_5fdc1be15c9e934a0a534eba5239d3c9Structure Duplicate() {
ST_5fdc1be15c9e934a0a534eba5239d3c9Structure t;
t.ssOrderName = this.ssOrderName;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedOn = this.ssCreatedOn;
t.ssMessage = this.ssMessage;
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
if (head == "ordername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderName")) variable.Value = ssOrderName; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
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
if (key == IdOrderName) {
return ssOrderName;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderName.Key.AsGuid) {
return ssOrderName;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderName = (string) other.AttributeGet(IdOrderName);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_5fdc1be15c9e934a0a534eba5239d3c9Structure
/// <summary>
/// RecordList type <code>ExcelOrderLogToExportList</code> that represents a record list of
///  <code>ExcelOrderLogToExport</code>
/// </summary>
public partial class RL_2ed2db5e92154c5915466940c779fa10 : GenericRecordList<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure>, IEnumerable, IEnumerator {

protected override ST_5fdc1be15c9e934a0a534eba5239d3c9Structure GetElementDefaultValue() {
return new ST_5fdc1be15c9e934a0a534eba5239d3c9Structure();
}

public T[] ToArray<T>(Func<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2ed2db5e92154c5915466940c779fa10 recordList, Func<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2ed2db5e92154c5915466940c779fa10(ST_5fdc1be15c9e934a0a534eba5239d3c9Structure[] array) {
  RL_2ed2db5e92154c5915466940c779fa10 result = new RL_2ed2db5e92154c5915466940c779fa10();
result.InnerFromArray(array);
    return result;
}

public static RL_2ed2db5e92154c5915466940c779fa10 ToList<T>(T[] array, Func <T, ST_5fdc1be15c9e934a0a534eba5239d3c9Structure> converter) {
  RL_2ed2db5e92154c5915466940c779fa10 result = new RL_2ed2db5e92154c5915466940c779fa10();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2ed2db5e92154c5915466940c779fa10 FromRestList<T>(RestList<T> restList, Func <T, ST_5fdc1be15c9e934a0a534eba5239d3c9Structure> converter) {
  RL_2ed2db5e92154c5915466940c779fa10 result = new RL_2ed2db5e92154c5915466940c779fa10();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2ed2db5e92154c5915466940c779fa10() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure> NewList() {
return new RL_2ed2db5e92154c5915466940c779fa10();
}


} // RL_2ed2db5e92154c5915466940c779fa10
}

