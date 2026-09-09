namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (VnnW5GuctUGPFrbVtG+hnQ)
///  <code>RC_dfad9538363a231d39994ccbe485157c</code> that represent
/// s <code>InvoicesReport48_FiltersRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoicesReport48_FiltersRecord
public partial struct RC_dfad9538363a231d39994ccbe485157c : ITypedRecord<RC_dfad9538363a231d39994ccbe485157c> {
internal static readonly GlobalObjectKey IdInvoicesReport48_Filters = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OJWt3zo2HSM5mUzL5IUVfA");

public ST_4301e782f48f03168dfeb78159c19548Structure ssSTInvoicesReport48_Filters;


public static implicit operator ST_4301e782f48f03168dfeb78159c19548Structure( RC_dfad9538363a231d39994ccbe485157c r) {
return r.ssSTInvoicesReport48_Filters;
}

public static implicit operator RC_dfad9538363a231d39994ccbe485157c (ST_4301e782f48f03168dfeb78159c19548Structure r) {
RC_dfad9538363a231d39994ccbe485157c res = new RC_dfad9538363a231d39994ccbe485157c ();
res.ssSTInvoicesReport48_Filters = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_dfad9538363a231d39994ccbe485157c() {
OptimizedAttributes = null;
ssSTInvoicesReport48_Filters = new ST_4301e782f48f03168dfeb78159c19548Structure();
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
    ssSTInvoicesReport48_Filters.OptimizedAttributes = value[0];
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
ssSTInvoicesReport48_Filters.Read( r, ref index);
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
public void ReadIM(RC_dfad9538363a231d39994ccbe485157c r) {
this = r;
}


public static bool operator == (RC_dfad9538363a231d39994ccbe485157c a, RC_dfad9538363a231d39994ccbe485157c b) {
if (a.ssSTInvoicesReport48_Filters != b.ssSTInvoicesReport48_Filters) return false;
return true;
}

public static bool operator != (RC_dfad9538363a231d39994ccbe485157c a, RC_dfad9538363a231d39994ccbe485157c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dfad9538363a231d39994ccbe485157c)) return false;
return (this == (RC_dfad9538363a231d39994ccbe485157c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoicesReport48_Filters.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoicesReport48_Filters.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoicesReport48_Filters.InternalRecursiveSave();
}


public RC_dfad9538363a231d39994ccbe485157c Duplicate() {
RC_dfad9538363a231d39994ccbe485157c t;
t.ssSTInvoicesReport48_Filters = (ST_4301e782f48f03168dfeb78159c19548Structure)this.ssSTInvoicesReport48_Filters.Duplicate();
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
if (head == "invoicesreport48_filters") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicesReport48_Filters")) variable.Value = ssSTInvoicesReport48_Filters; else variable.Optimized = true;
variable.SetFieldName("invoicesreport48_filters");
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
if (key == IdInvoicesReport48_Filters) {
return ssSTInvoicesReport48_Filters;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoicesReport48_Filters.Key.AsGuid) {
return ssSTInvoicesReport48_Filters;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoicesReport48_Filters.FillFromOther((IRecord) other.AttributeGet(IdInvoicesReport48_Filters));
}
} // RC_dfad9538363a231d39994ccbe485157c
/// <summary>
/// RecordList type <code>InvoicesReport48_FiltersRecordList</code> that represents a record list of
///  <code>InvoicesReport48_Filters</code>
/// </summary>
public partial class RL_fbaa61a2affd4045980de0c1b65c30bf : GenericRecordList<RC_dfad9538363a231d39994ccbe485157c>, IEnumerable, IEnumerator {

protected override RC_dfad9538363a231d39994ccbe485157c GetElementDefaultValue() {
return new RC_dfad9538363a231d39994ccbe485157c();
}

public T[] ToArray<T>(Func<RC_dfad9538363a231d39994ccbe485157c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fbaa61a2affd4045980de0c1b65c30bf recordList, Func<RC_dfad9538363a231d39994ccbe485157c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fbaa61a2affd4045980de0c1b65c30bf(RC_dfad9538363a231d39994ccbe485157c[] array) {
  RL_fbaa61a2affd4045980de0c1b65c30bf result = new RL_fbaa61a2affd4045980de0c1b65c30bf();
result.InnerFromArray(array);
    return result;
}

public static RL_fbaa61a2affd4045980de0c1b65c30bf ToList<T>(T[] array, Func <T, RC_dfad9538363a231d39994ccbe485157c> converter) {
  RL_fbaa61a2affd4045980de0c1b65c30bf result = new RL_fbaa61a2affd4045980de0c1b65c30bf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fbaa61a2affd4045980de0c1b65c30bf FromRestList<T>(RestList<T> restList, Func <T, RC_dfad9538363a231d39994ccbe485157c> converter) {
  RL_fbaa61a2affd4045980de0c1b65c30bf result = new RL_fbaa61a2affd4045980de0c1b65c30bf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fbaa61a2affd4045980de0c1b65c30bf() : base() {
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
protected override OSList<RC_dfad9538363a231d39994ccbe485157c> NewList() {
return new RL_fbaa61a2affd4045980de0c1b65c30bf();
}


} // RL_fbaa61a2affd4045980de0c1b65c30bf
}

