namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (FDoaOmrKO0W9wJWWHuZqUg)
///  <code>RC_7f2610cf0c5fadd86ba78c902c31effa</code> that represent
/// s <code>InvoiceExtendedItemRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedItemRecord
public partial struct RC_7f2610cf0c5fadd86ba78c902c31effa : ITypedRecord<RC_7f2610cf0c5fadd86ba78c902c31effa> {
internal static readonly GlobalObjectKey IdInvoiceExtendedItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zxAmf18M2K1rp4yQLDHv+g");

public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ssENInvoiceExtendedItem;


public static implicit operator EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord( RC_7f2610cf0c5fadd86ba78c902c31effa r) {
return r.ssENInvoiceExtendedItem;
}

public static implicit operator RC_7f2610cf0c5fadd86ba78c902c31effa (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord r) {
RC_7f2610cf0c5fadd86ba78c902c31effa res = new RC_7f2610cf0c5fadd86ba78c902c31effa ();
res.ssENInvoiceExtendedItem = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedItem.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedItem.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_7f2610cf0c5fadd86ba78c902c31effa() {
OptimizedAttributes = null;
ssENInvoiceExtendedItem = new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedItem.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedItem.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedItem.Read( r, ref index);
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
public void ReadIM(RC_7f2610cf0c5fadd86ba78c902c31effa r) {
this = r;
}


public static bool operator == (RC_7f2610cf0c5fadd86ba78c902c31effa a, RC_7f2610cf0c5fadd86ba78c902c31effa b) {
if (a.ssENInvoiceExtendedItem != b.ssENInvoiceExtendedItem) return false;
return true;
}

public static bool operator != (RC_7f2610cf0c5fadd86ba78c902c31effa a, RC_7f2610cf0c5fadd86ba78c902c31effa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7f2610cf0c5fadd86ba78c902c31effa)) return false;
return (this == (RC_7f2610cf0c5fadd86ba78c902c31effa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedItem.InternalRecursiveSave();
}


public RC_7f2610cf0c5fadd86ba78c902c31effa Duplicate() {
RC_7f2610cf0c5fadd86ba78c902c31effa t;
t.ssENInvoiceExtendedItem = (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord)this.ssENInvoiceExtendedItem.Duplicate();
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
if (head == "invoiceextendeditem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedItem")) variable.Value = ssENInvoiceExtendedItem; else variable.Optimized = true;
variable.SetFieldName("invoiceextendeditem");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedItem.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedItem.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedItem) {
return ssENInvoiceExtendedItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedItem.Key.AsGuid) {
return ssENInvoiceExtendedItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedItem.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedItem));
}
} // RC_7f2610cf0c5fadd86ba78c902c31effa
/// <summary>
/// RecordList type <code>InvoiceExtendedItemRecordList</code> that represents a record list of
///  <code>InvoiceExtendedItem</code>
/// </summary>
public partial class RL_772f048f6ee632348101044a1e0eef2f : GenericRecordList<RC_7f2610cf0c5fadd86ba78c902c31effa>, IEnumerable, IEnumerator {

protected override RC_7f2610cf0c5fadd86ba78c902c31effa GetElementDefaultValue() {
return new RC_7f2610cf0c5fadd86ba78c902c31effa();
}

public T[] ToArray<T>(Func<RC_7f2610cf0c5fadd86ba78c902c31effa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_772f048f6ee632348101044a1e0eef2f recordList, Func<RC_7f2610cf0c5fadd86ba78c902c31effa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_772f048f6ee632348101044a1e0eef2f(RC_7f2610cf0c5fadd86ba78c902c31effa[] array) {
  RL_772f048f6ee632348101044a1e0eef2f result = new RL_772f048f6ee632348101044a1e0eef2f();
result.InnerFromArray(array);
    return result;
}

public static RL_772f048f6ee632348101044a1e0eef2f ToList<T>(T[] array, Func <T, RC_7f2610cf0c5fadd86ba78c902c31effa> converter) {
  RL_772f048f6ee632348101044a1e0eef2f result = new RL_772f048f6ee632348101044a1e0eef2f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_772f048f6ee632348101044a1e0eef2f FromRestList<T>(RestList<T> restList, Func <T, RC_7f2610cf0c5fadd86ba78c902c31effa> converter) {
  RL_772f048f6ee632348101044a1e0eef2f result = new RL_772f048f6ee632348101044a1e0eef2f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_772f048f6ee632348101044a1e0eef2f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7f2610cf0c5fadd86ba78c902c31effa> NewList() {
return new RL_772f048f6ee632348101044a1e0eef2f();
}


} // RL_772f048f6ee632348101044a1e0eef2f
}

