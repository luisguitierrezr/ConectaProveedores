namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pn3zOlAkZkm9+ypm1JfKZw)
///  <code>RC_47cc380fa539ce90830b02515458ecd2</code> that represent
/// s <code>RequisitionVersionRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionVersionRecord
public partial struct RC_47cc380fa539ce90830b02515458ecd2 : ITypedRecord<RC_47cc380fa539ce90830b02515458ecd2> {
internal static readonly GlobalObjectKey IdRequisitionVersion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DzjMRzmlkM6DCwJRVFjs0g");

public EN_74284c742ed8c8eb5a05978b570ef620EntityRecord ssENRequisitionVersion;


public static implicit operator EN_74284c742ed8c8eb5a05978b570ef620EntityRecord( RC_47cc380fa539ce90830b02515458ecd2 r) {
return r.ssENRequisitionVersion;
}

public static implicit operator RC_47cc380fa539ce90830b02515458ecd2 (EN_74284c742ed8c8eb5a05978b570ef620EntityRecord r) {
RC_47cc380fa539ce90830b02515458ecd2 res = new RC_47cc380fa539ce90830b02515458ecd2 ();
res.ssENRequisitionVersion = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionVersion.ChangedAttributes = value;
}
get {
    return ssENRequisitionVersion.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_47cc380fa539ce90830b02515458ecd2() {
OptimizedAttributes = null;
ssENRequisitionVersion = new EN_74284c742ed8c8eb5a05978b570ef620EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionVersion.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionVersion.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionVersion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionVersion.Read( r, ref index);
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
public void ReadIM(RC_47cc380fa539ce90830b02515458ecd2 r) {
this = r;
}


public static bool operator == (RC_47cc380fa539ce90830b02515458ecd2 a, RC_47cc380fa539ce90830b02515458ecd2 b) {
if (a.ssENRequisitionVersion != b.ssENRequisitionVersion) return false;
return true;
}

public static bool operator != (RC_47cc380fa539ce90830b02515458ecd2 a, RC_47cc380fa539ce90830b02515458ecd2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_47cc380fa539ce90830b02515458ecd2)) return false;
return (this == (RC_47cc380fa539ce90830b02515458ecd2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionVersion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionVersion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionVersion.InternalRecursiveSave();
}


public RC_47cc380fa539ce90830b02515458ecd2 Duplicate() {
RC_47cc380fa539ce90830b02515458ecd2 t;
t.ssENRequisitionVersion = (EN_74284c742ed8c8eb5a05978b570ef620EntityRecord)this.ssENRequisitionVersion.Duplicate();
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
if (head == "requisitionversion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionVersion")) variable.Value = ssENRequisitionVersion; else variable.Optimized = true;
variable.SetFieldName("requisitionversion");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionVersion.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionVersion.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionVersion) {
return ssENRequisitionVersion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionVersion.Key.AsGuid) {
return ssENRequisitionVersion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionVersion.FillFromOther((IRecord) other.AttributeGet(IdRequisitionVersion));
}
} // RC_47cc380fa539ce90830b02515458ecd2
/// <summary>
/// RecordList type <code>RequisitionVersionRecordList</code> that represents a record list of
///  <code>RequisitionVersion</code>
/// </summary>
public partial class RL_16a3629886d5e012aa547b904dd63379 : GenericRecordList<RC_47cc380fa539ce90830b02515458ecd2>, IEnumerable, IEnumerator {

protected override RC_47cc380fa539ce90830b02515458ecd2 GetElementDefaultValue() {
return new RC_47cc380fa539ce90830b02515458ecd2();
}

public T[] ToArray<T>(Func<RC_47cc380fa539ce90830b02515458ecd2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_16a3629886d5e012aa547b904dd63379 recordList, Func<RC_47cc380fa539ce90830b02515458ecd2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_16a3629886d5e012aa547b904dd63379(RC_47cc380fa539ce90830b02515458ecd2[] array) {
  RL_16a3629886d5e012aa547b904dd63379 result = new RL_16a3629886d5e012aa547b904dd63379();
result.InnerFromArray(array);
    return result;
}

public static RL_16a3629886d5e012aa547b904dd63379 ToList<T>(T[] array, Func <T, RC_47cc380fa539ce90830b02515458ecd2> converter) {
  RL_16a3629886d5e012aa547b904dd63379 result = new RL_16a3629886d5e012aa547b904dd63379();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_16a3629886d5e012aa547b904dd63379 FromRestList<T>(RestList<T> restList, Func <T, RC_47cc380fa539ce90830b02515458ecd2> converter) {
  RL_16a3629886d5e012aa547b904dd63379 result = new RL_16a3629886d5e012aa547b904dd63379();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_16a3629886d5e012aa547b904dd63379() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_47cc380fa539ce90830b02515458ecd2> NewList() {
return new RL_16a3629886d5e012aa547b904dd63379();
}


} // RL_16a3629886d5e012aa547b904dd63379
}

