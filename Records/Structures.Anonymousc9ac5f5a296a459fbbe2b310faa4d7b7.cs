namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Wl+syWopn0W74rMQ+qTXtw)
///  <code>RC_bb81744faa58ae73e7cd8db74cb32155</code> that represents <code>RequisitionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RequisitionRecord
public partial struct RC_bb81744faa58ae73e7cd8db74cb32155 : ITypedRecord<RC_bb81744faa58ae73e7cd8db74cb32155> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;


public static implicit operator EN_98680591dcf3728e0877a90eb5e1e552EntityRecord( RC_bb81744faa58ae73e7cd8db74cb32155 r) {
return r.ssENRequisition;
}

public static implicit operator RC_bb81744faa58ae73e7cd8db74cb32155 (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord r) {
RC_bb81744faa58ae73e7cd8db74cb32155 res = new RC_bb81744faa58ae73e7cd8db74cb32155 ();
res.ssENRequisition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisition.ChangedAttributes = value;
}
get {
    return ssENRequisition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_bb81744faa58ae73e7cd8db74cb32155() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(58,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_bb81744faa58ae73e7cd8db74cb32155 r) {
this = r;
}


public static bool operator == (RC_bb81744faa58ae73e7cd8db74cb32155 a, RC_bb81744faa58ae73e7cd8db74cb32155 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
return true;
}

public static bool operator != (RC_bb81744faa58ae73e7cd8db74cb32155 a, RC_bb81744faa58ae73e7cd8db74cb32155 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bb81744faa58ae73e7cd8db74cb32155)) return false;
return (this == (RC_bb81744faa58ae73e7cd8db74cb32155)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
}


public RC_bb81744faa58ae73e7cd8db74cb32155 Duplicate() {
RC_bb81744faa58ae73e7cd8db74cb32155 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisition) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
}
} // RC_bb81744faa58ae73e7cd8db74cb32155
/// <summary>
/// RecordList type <code>RequisitionRecordList</code> that represents a record list of
///  <code>Requisition</code>
/// </summary>
public partial class RL_0ad79b64673379e41188da81c3628c0f : GenericRecordList<RC_bb81744faa58ae73e7cd8db74cb32155>, IEnumerable, IEnumerator {

protected override RC_bb81744faa58ae73e7cd8db74cb32155 GetElementDefaultValue() {
return new RC_bb81744faa58ae73e7cd8db74cb32155();
}

public T[] ToArray<T>(Func<RC_bb81744faa58ae73e7cd8db74cb32155, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0ad79b64673379e41188da81c3628c0f recordList, Func<RC_bb81744faa58ae73e7cd8db74cb32155, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0ad79b64673379e41188da81c3628c0f(RC_bb81744faa58ae73e7cd8db74cb32155[] array) {
  RL_0ad79b64673379e41188da81c3628c0f result = new RL_0ad79b64673379e41188da81c3628c0f();
result.InnerFromArray(array);
    return result;
}

public static RL_0ad79b64673379e41188da81c3628c0f ToList<T>(T[] array, Func <T, RC_bb81744faa58ae73e7cd8db74cb32155> converter) {
  RL_0ad79b64673379e41188da81c3628c0f result = new RL_0ad79b64673379e41188da81c3628c0f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0ad79b64673379e41188da81c3628c0f FromRestList<T>(RestList<T> restList, Func <T, RC_bb81744faa58ae73e7cd8db74cb32155> converter) {
  RL_0ad79b64673379e41188da81c3628c0f result = new RL_0ad79b64673379e41188da81c3628c0f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0ad79b64673379e41188da81c3628c0f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(58,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bb81744faa58ae73e7cd8db74cb32155> NewList() {
return new RL_0ad79b64673379e41188da81c3628c0f();
}


} // RL_0ad79b64673379e41188da81c3628c0f
}

