namespace ssConectaProveedores {
/// <summary>
/// [Structure] EntryOrderRequestUpdate (UnQm8NBtWEyIPpMEjYc4dg)
///  <code>ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure</code> that represent
/// s <code>EntryOrderRequestUpdate</code> <p>Description: </p>
/// </summary>
// Name: EntryOrderRequestUpdate
public partial struct ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure : ITypedRecord<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> {
internal static readonly GlobalObjectKey IdMovementClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MJG_VJH0XUWstS3azeoI2Q");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VOVG+zrf20+aWXHvN3Odaw");
internal static readonly GlobalObjectKey IdEntryNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*k_qxgD0qfEuV_gbGpgeB2g");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HhUPWqgiSEukJxu0B0if0Q");
internal static readonly GlobalObjectKey IdUUID = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l1Dp3ucWTkigpO5R7iz6ag");
internal static readonly GlobalObjectKey IdEntryNumberEM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dFowiIK7NEaVtfM_kV0KGA");
internal static readonly GlobalObjectKey IdEntryYearEM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vmEHKvArF0iXwOH5wotxPg");
internal static readonly GlobalObjectKey IdReferenceEM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EXV1p4I9YkagY0_R2K4Fzg");
internal static readonly GlobalObjectKey IdRows = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wg0IcG8fR0mhBjZ2cNhfsg");

public string ssMovementClass;

public string ssOrderNumber;

public string ssEntryNumber;

public string ssSupplierNumber;

public string ssUUID;

public string ssEntryNumberEM;

public string ssEntryYearEM;

public string ssReferenceEM;

public RL_800c0b51440fd41c56528d60815ca788 ssRows;


public BitArray OptimizedAttributes;

public ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure() {
OptimizedAttributes = null;
ssMovementClass = "";
ssOrderNumber = "";
ssEntryNumber = "";
ssSupplierNumber = "";
ssUUID = "";
ssEntryNumberEM = "";
ssEntryYearEM = "";
ssReferenceEM = "";
ssRows = new RL_800c0b51440fd41c56528d60815ca788();
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
ssMovementClass = r.ReadText(index++, "EntryOrderRequestUpdate.MovementClass", "");
ssOrderNumber = r.ReadText(index++, "EntryOrderRequestUpdate.OrderNumber", "");
ssEntryNumber = r.ReadText(index++, "EntryOrderRequestUpdate.EntryNumber", "");
ssSupplierNumber = r.ReadText(index++, "EntryOrderRequestUpdate.SupplierNumber", "");
ssUUID = r.ReadText(index++, "EntryOrderRequestUpdate.UUID", "");
ssEntryNumberEM = r.ReadText(index++, "EntryOrderRequestUpdate.EntryNumberEM", "");
ssEntryYearEM = r.ReadText(index++, "EntryOrderRequestUpdate.EntryYearEM", "");
ssReferenceEM = r.ReadText(index++, "EntryOrderRequestUpdate.ReferenceEM", "");
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
public void ReadIM(ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure r) {
this = r;
}


public static bool operator == (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure a, ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure b) {
if (a.ssMovementClass != b.ssMovementClass) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssEntryNumber != b.ssEntryNumber) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssUUID != b.ssUUID) return false;
if (a.ssEntryNumberEM != b.ssEntryNumberEM) return false;
if (a.ssEntryYearEM != b.ssEntryYearEM) return false;
if (a.ssReferenceEM != b.ssReferenceEM) return false;
if (a.ssRows != b.ssRows) return false;
return true;
}

public static bool operator != (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure a, ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure)) return false;
return (this == (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMovementClass.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssEntryNumber.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssUUID.GetHashCode()
 ^ ssEntryNumberEM.GetHashCode()
 ^ ssEntryYearEM.GetHashCode()
 ^ ssReferenceEM.GetHashCode()
 ^ ssRows.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssRows.RecursiveReset();
}

public void InternalRecursiveSave() {
ssRows.InternalRecursiveSave();
}


public ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure Duplicate() {
ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure t;
t.ssMovementClass = this.ssMovementClass;
t.ssOrderNumber = this.ssOrderNumber;
t.ssEntryNumber = this.ssEntryNumber;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssUUID = this.ssUUID;
t.ssEntryNumberEM = this.ssEntryNumberEM;
t.ssEntryYearEM = this.ssEntryYearEM;
t.ssReferenceEM = this.ssReferenceEM;
t.ssRows = (RL_800c0b51440fd41c56528d60815ca788)this.ssRows.Duplicate();
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
if (head == "movementclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MovementClass")) variable.Value = ssMovementClass; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "entrynumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryNumber")) variable.Value = ssEntryNumber; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "uuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UUID")) variable.Value = ssUUID; else variable.Optimized = true;
} else if (head == "entrynumberem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryNumberEM")) variable.Value = ssEntryNumberEM; else variable.Optimized = true;
} else if (head == "entryyearem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryYearEM")) variable.Value = ssEntryYearEM; else variable.Optimized = true;
} else if (head == "referenceem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ReferenceEM")) variable.Value = ssReferenceEM; else variable.Optimized = true;
} else if (head == "rows") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Rows")) variable.Value = ssRows; else variable.Optimized = true;
variable.SetFieldName("rows");
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
if (key == IdMovementClass) {
return ssMovementClass;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdEntryNumber) {
return ssEntryNumber;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdUUID) {
return ssUUID;
}
if (key == IdEntryNumberEM) {
return ssEntryNumberEM;
}
if (key == IdEntryYearEM) {
return ssEntryYearEM;
}
if (key == IdReferenceEM) {
return ssReferenceEM;
}
if (key == IdRows) {
return ssRows;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMovementClass.Key.AsGuid) {
return ssMovementClass;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdEntryNumber.Key.AsGuid) {
return ssEntryNumber;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdUUID.Key.AsGuid) {
return ssUUID;
}
if (attributeKey == IdEntryNumberEM.Key.AsGuid) {
return ssEntryNumberEM;
}
if (attributeKey == IdEntryYearEM.Key.AsGuid) {
return ssEntryYearEM;
}
if (attributeKey == IdReferenceEM.Key.AsGuid) {
return ssReferenceEM;
}
if (attributeKey == IdRows.Key.AsGuid) {
return ssRows;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssMovementClass = (string) other.AttributeGet(IdMovementClass);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssEntryNumber = (string) other.AttributeGet(IdEntryNumber);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssUUID = (string) other.AttributeGet(IdUUID);
ssEntryNumberEM = (string) other.AttributeGet(IdEntryNumberEM);
ssEntryYearEM = (string) other.AttributeGet(IdEntryYearEM);
ssReferenceEM = (string) other.AttributeGet(IdReferenceEM);
ssRows = new RL_800c0b51440fd41c56528d60815ca788();
ssRows.FillFromOther((IOSList) other.AttributeGet(IdRows));
}
} // ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure
/// <summary>
/// RecordList type <code>EntryOrderRequestUpdateList</code> that represents a record list of
///  <code>EntryOrderRequestUpdate</code>
/// </summary>
public partial class RL_24f056236e3761f7c992dda9e8482a3b : GenericRecordList<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure>, IEnumerable, IEnumerator {

protected override ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure GetElementDefaultValue() {
return new ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure();
}

public T[] ToArray<T>(Func<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_24f056236e3761f7c992dda9e8482a3b recordList, Func<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_24f056236e3761f7c992dda9e8482a3b(ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure[] array) {
  RL_24f056236e3761f7c992dda9e8482a3b result = new RL_24f056236e3761f7c992dda9e8482a3b();
result.InnerFromArray(array);
    return result;
}

public static RL_24f056236e3761f7c992dda9e8482a3b ToList<T>(T[] array, Func <T, ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> converter) {
  RL_24f056236e3761f7c992dda9e8482a3b result = new RL_24f056236e3761f7c992dda9e8482a3b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_24f056236e3761f7c992dda9e8482a3b FromRestList<T>(RestList<T> restList, Func <T, ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> converter) {
  RL_24f056236e3761f7c992dda9e8482a3b result = new RL_24f056236e3761f7c992dda9e8482a3b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_24f056236e3761f7c992dda9e8482a3b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> NewList() {
return new RL_24f056236e3761f7c992dda9e8482a3b();
}


} // RL_24f056236e3761f7c992dda9e8482a3b
}

