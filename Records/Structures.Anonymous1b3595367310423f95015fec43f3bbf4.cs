namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (NpU1GxBzP0KVAV_sQ_O79A)
///  <code>RC_961fb69f34436852965350a75ed3c8b8</code> that represents <code>RegionsDropdownRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RegionsDropdownRecord
public partial struct RC_961fb69f34436852965350a75ed3c8b8 : ITypedRecord<RC_961fb69f34436852965350a75ed3c8b8> {
internal static readonly GlobalObjectKey IdRegionsDropdown = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*n7YflkM0UmiWU1CnXtPIuA");

public ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure ssSTRegionsDropdown;


public static implicit operator ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure( RC_961fb69f34436852965350a75ed3c8b8 r) {
return r.ssSTRegionsDropdown;
}

public static implicit operator RC_961fb69f34436852965350a75ed3c8b8 (ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure r) {
RC_961fb69f34436852965350a75ed3c8b8 res = new RC_961fb69f34436852965350a75ed3c8b8 ();
res.ssSTRegionsDropdown = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_961fb69f34436852965350a75ed3c8b8() {
OptimizedAttributes = null;
ssSTRegionsDropdown = new ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure();
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
    ssSTRegionsDropdown.OptimizedAttributes = value[0];
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
ssSTRegionsDropdown.Read( r, ref index);
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
public void ReadIM(RC_961fb69f34436852965350a75ed3c8b8 r) {
this = r;
}


public static bool operator == (RC_961fb69f34436852965350a75ed3c8b8 a, RC_961fb69f34436852965350a75ed3c8b8 b) {
if (a.ssSTRegionsDropdown != b.ssSTRegionsDropdown) return false;
return true;
}

public static bool operator != (RC_961fb69f34436852965350a75ed3c8b8 a, RC_961fb69f34436852965350a75ed3c8b8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_961fb69f34436852965350a75ed3c8b8)) return false;
return (this == (RC_961fb69f34436852965350a75ed3c8b8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRegionsDropdown.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRegionsDropdown.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRegionsDropdown.InternalRecursiveSave();
}


public RC_961fb69f34436852965350a75ed3c8b8 Duplicate() {
RC_961fb69f34436852965350a75ed3c8b8 t;
t.ssSTRegionsDropdown = (ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure)this.ssSTRegionsDropdown.Duplicate();
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
if (head == "regionsdropdown") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionsDropdown")) variable.Value = ssSTRegionsDropdown; else variable.Optimized = true;
variable.SetFieldName("regionsdropdown");
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
if (key == IdRegionsDropdown) {
return ssSTRegionsDropdown;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRegionsDropdown.Key.AsGuid) {
return ssSTRegionsDropdown;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRegionsDropdown.FillFromOther((IRecord) other.AttributeGet(IdRegionsDropdown));
}
} // RC_961fb69f34436852965350a75ed3c8b8
/// <summary>
/// RecordList type <code>RegionsDropdownRecordList</code> that represents a record list of
///  <code>RegionsDropdown</code>
/// </summary>
public partial class RL_ef054de7efcbb2333554911096d83023 : GenericRecordList<RC_961fb69f34436852965350a75ed3c8b8>, IEnumerable, IEnumerator {

protected override RC_961fb69f34436852965350a75ed3c8b8 GetElementDefaultValue() {
return new RC_961fb69f34436852965350a75ed3c8b8();
}

public T[] ToArray<T>(Func<RC_961fb69f34436852965350a75ed3c8b8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ef054de7efcbb2333554911096d83023 recordList, Func<RC_961fb69f34436852965350a75ed3c8b8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ef054de7efcbb2333554911096d83023(RC_961fb69f34436852965350a75ed3c8b8[] array) {
  RL_ef054de7efcbb2333554911096d83023 result = new RL_ef054de7efcbb2333554911096d83023();
result.InnerFromArray(array);
    return result;
}

public static RL_ef054de7efcbb2333554911096d83023 ToList<T>(T[] array, Func <T, RC_961fb69f34436852965350a75ed3c8b8> converter) {
  RL_ef054de7efcbb2333554911096d83023 result = new RL_ef054de7efcbb2333554911096d83023();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ef054de7efcbb2333554911096d83023 FromRestList<T>(RestList<T> restList, Func <T, RC_961fb69f34436852965350a75ed3c8b8> converter) {
  RL_ef054de7efcbb2333554911096d83023 result = new RL_ef054de7efcbb2333554911096d83023();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ef054de7efcbb2333554911096d83023() : base() {
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
protected override OSList<RC_961fb69f34436852965350a75ed3c8b8> NewList() {
return new RL_ef054de7efcbb2333554911096d83023();
}


} // RL_ef054de7efcbb2333554911096d83023
}

