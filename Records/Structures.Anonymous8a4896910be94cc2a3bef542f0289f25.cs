namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kZZIiukLwkyjvvVC8CifJQ)
///  <code>RC_c947fd25bedc3c8ec938df5b28c2643b</code> that represent
/// s <code>InvoiceCommentSARecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceCommentSARecord
public partial struct RC_c947fd25bedc3c8ec938df5b28c2643b : ITypedRecord<RC_c947fd25bedc3c8ec938df5b28c2643b> {
internal static readonly GlobalObjectKey IdInvoiceCommentSA = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Jf1Hydy+jjzJON9bKMJkOw");

public ST_f1259a41db43b1c9d9faa83c38ada6a7Structure ssSTInvoiceCommentSA;


public static implicit operator ST_f1259a41db43b1c9d9faa83c38ada6a7Structure( RC_c947fd25bedc3c8ec938df5b28c2643b r) {
return r.ssSTInvoiceCommentSA;
}

public static implicit operator RC_c947fd25bedc3c8ec938df5b28c2643b (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure r) {
RC_c947fd25bedc3c8ec938df5b28c2643b res = new RC_c947fd25bedc3c8ec938df5b28c2643b ();
res.ssSTInvoiceCommentSA = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c947fd25bedc3c8ec938df5b28c2643b() {
OptimizedAttributes = null;
ssSTInvoiceCommentSA = new ST_f1259a41db43b1c9d9faa83c38ada6a7Structure();
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
    ssSTInvoiceCommentSA.OptimizedAttributes = value[0];
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
ssSTInvoiceCommentSA.Read( r, ref index);
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
public void ReadIM(RC_c947fd25bedc3c8ec938df5b28c2643b r) {
this = r;
}


public static bool operator == (RC_c947fd25bedc3c8ec938df5b28c2643b a, RC_c947fd25bedc3c8ec938df5b28c2643b b) {
if (a.ssSTInvoiceCommentSA != b.ssSTInvoiceCommentSA) return false;
return true;
}

public static bool operator != (RC_c947fd25bedc3c8ec938df5b28c2643b a, RC_c947fd25bedc3c8ec938df5b28c2643b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c947fd25bedc3c8ec938df5b28c2643b)) return false;
return (this == (RC_c947fd25bedc3c8ec938df5b28c2643b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoiceCommentSA.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoiceCommentSA.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoiceCommentSA.InternalRecursiveSave();
}


public RC_c947fd25bedc3c8ec938df5b28c2643b Duplicate() {
RC_c947fd25bedc3c8ec938df5b28c2643b t;
t.ssSTInvoiceCommentSA = (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure)this.ssSTInvoiceCommentSA.Duplicate();
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
if (head == "invoicecommentsa") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceCommentSA")) variable.Value = ssSTInvoiceCommentSA; else variable.Optimized = true;
variable.SetFieldName("invoicecommentsa");
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
if (key == IdInvoiceCommentSA) {
return ssSTInvoiceCommentSA;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceCommentSA.Key.AsGuid) {
return ssSTInvoiceCommentSA;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoiceCommentSA.FillFromOther((IRecord) other.AttributeGet(IdInvoiceCommentSA));
}
} // RC_c947fd25bedc3c8ec938df5b28c2643b
/// <summary>
/// RecordList type <code>InvoiceCommentSARecordList</code> that represents a record list of
///  <code>InvoiceCommentSA</code>
/// </summary>
public partial class RL_dab42c97694aa69123fdd0e55fca222f : GenericRecordList<RC_c947fd25bedc3c8ec938df5b28c2643b>, IEnumerable, IEnumerator {

protected override RC_c947fd25bedc3c8ec938df5b28c2643b GetElementDefaultValue() {
return new RC_c947fd25bedc3c8ec938df5b28c2643b();
}

public T[] ToArray<T>(Func<RC_c947fd25bedc3c8ec938df5b28c2643b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dab42c97694aa69123fdd0e55fca222f recordList, Func<RC_c947fd25bedc3c8ec938df5b28c2643b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dab42c97694aa69123fdd0e55fca222f(RC_c947fd25bedc3c8ec938df5b28c2643b[] array) {
  RL_dab42c97694aa69123fdd0e55fca222f result = new RL_dab42c97694aa69123fdd0e55fca222f();
result.InnerFromArray(array);
    return result;
}

public static RL_dab42c97694aa69123fdd0e55fca222f ToList<T>(T[] array, Func <T, RC_c947fd25bedc3c8ec938df5b28c2643b> converter) {
  RL_dab42c97694aa69123fdd0e55fca222f result = new RL_dab42c97694aa69123fdd0e55fca222f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dab42c97694aa69123fdd0e55fca222f FromRestList<T>(RestList<T> restList, Func <T, RC_c947fd25bedc3c8ec938df5b28c2643b> converter) {
  RL_dab42c97694aa69123fdd0e55fca222f result = new RL_dab42c97694aa69123fdd0e55fca222f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dab42c97694aa69123fdd0e55fca222f() : base() {
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
protected override OSList<RC_c947fd25bedc3c8ec938df5b28c2643b> NewList() {
return new RL_dab42c97694aa69123fdd0e55fca222f();
}


} // RL_dab42c97694aa69123fdd0e55fca222f
}

