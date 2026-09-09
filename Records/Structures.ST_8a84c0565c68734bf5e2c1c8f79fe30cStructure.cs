namespace ssConectaProveedores {
/// <summary>
/// [Structure] ExcelOrderEntriesLogToExport (U7PGl2Jkl0uGYEAvo2zwpQ)
///  <code>ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure</code> that represent
/// s <code>ExcelOrderEntriesLogToExport</code> <p>Description: Excel Log To Export Struct.</p>
/// </summary>
// Name: ExcelOrderEntriesLogToExport
public partial struct ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure : ITypedRecord<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> {
internal static readonly GlobalObjectKey IdItemPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8Tmpmjmnr06tk4PVCmGDmg");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QV6j8vxV70OQiBuegnMNkg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YSOA8gNbsEaZ5AmEXYIvBQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Amdzqbhx1kyyjflcAPn6zg");

public string ssItemPosition;

public decimal ssQuantity;

public string ssCreatedBy;

public DateTime ssCreatedOn;


public BitArray OptimizedAttributes;

public ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure() {
OptimizedAttributes = null;
ssItemPosition = "";
ssQuantity = 0.0M;
ssCreatedBy = "";
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssItemPosition = r.ReadText(index++, "ExcelOrderEntriesLogToExport.ItemPosition", "");
ssQuantity = r.ReadDecimal(index++, "ExcelOrderEntriesLogToExport.Quantity", 0.0M);
ssCreatedBy = r.ReadText(index++, "ExcelOrderEntriesLogToExport.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "ExcelOrderEntriesLogToExport.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure r) {
this = r;
}


public static bool operator == (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure a, ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure b) {
if (a.ssItemPosition != b.ssItemPosition) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
return true;
}

public static bool operator != (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure a, ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure)) return false;
return (this == (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssItemPosition.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure Duplicate() {
ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure t;
t.ssItemPosition = this.ssItemPosition;
t.ssQuantity = this.ssQuantity;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedOn = this.ssCreatedOn;
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
if (head == "itemposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemPosition")) variable.Value = ssItemPosition; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity")) variable.Value = ssQuantity; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
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
if (key == IdItemPosition) {
return ssItemPosition;
}
if (key == IdQuantity) {
return ssQuantity;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItemPosition.Key.AsGuid) {
return ssItemPosition;
}
if (attributeKey == IdQuantity.Key.AsGuid) {
return ssQuantity;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssItemPosition = (string) other.AttributeGet(IdItemPosition);
ssQuantity = (decimal) other.AttributeGet(IdQuantity);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
}
} // ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure
/// <summary>
/// RecordList type <code>ExcelOrderEntriesLogToExportList</code> that represents a record list of
///  <code>ExcelOrderEntriesLogToExport</code>
/// </summary>
public partial class RL_1089d48ddd01268f96cdb97961ee0e9d : GenericRecordList<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure>, IEnumerable, IEnumerator {

protected override ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure GetElementDefaultValue() {
return new ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure();
}

public T[] ToArray<T>(Func<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1089d48ddd01268f96cdb97961ee0e9d recordList, Func<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1089d48ddd01268f96cdb97961ee0e9d(ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure[] array) {
  RL_1089d48ddd01268f96cdb97961ee0e9d result = new RL_1089d48ddd01268f96cdb97961ee0e9d();
result.InnerFromArray(array);
    return result;
}

public static RL_1089d48ddd01268f96cdb97961ee0e9d ToList<T>(T[] array, Func <T, ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> converter) {
  RL_1089d48ddd01268f96cdb97961ee0e9d result = new RL_1089d48ddd01268f96cdb97961ee0e9d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1089d48ddd01268f96cdb97961ee0e9d FromRestList<T>(RestList<T> restList, Func <T, ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> converter) {
  RL_1089d48ddd01268f96cdb97961ee0e9d result = new RL_1089d48ddd01268f96cdb97961ee0e9d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1089d48ddd01268f96cdb97961ee0e9d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> NewList() {
return new RL_1089d48ddd01268f96cdb97961ee0e9d();
}


} // RL_1089d48ddd01268f96cdb97961ee0e9d
}

