namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (dT9jMnlu90S4TSSHxjtg8w)
///  <code>RC_e7b4e13946d568a48ef39b6a3bfce595</code> that represent
/// s <code>InvoiceExtendedItemTaxRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedItemTaxRecord
public partial struct RC_e7b4e13946d568a48ef39b6a3bfce595 : ITypedRecord<RC_e7b4e13946d568a48ef39b6a3bfce595> {
internal static readonly GlobalObjectKey IdInvoiceExtendedItemTax = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OeG059VGpGiO85tqO_zllQ");

public EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord ssENInvoiceExtendedItemTax;


public static implicit operator EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord( RC_e7b4e13946d568a48ef39b6a3bfce595 r) {
return r.ssENInvoiceExtendedItemTax;
}

public static implicit operator RC_e7b4e13946d568a48ef39b6a3bfce595 (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord r) {
RC_e7b4e13946d568a48ef39b6a3bfce595 res = new RC_e7b4e13946d568a48ef39b6a3bfce595 ();
res.ssENInvoiceExtendedItemTax = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedItemTax.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedItemTax.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e7b4e13946d568a48ef39b6a3bfce595() {
OptimizedAttributes = null;
ssENInvoiceExtendedItemTax = new EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedItemTax.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedItemTax.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedItemTax.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedItemTax.Read( r, ref index);
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
public void ReadIM(RC_e7b4e13946d568a48ef39b6a3bfce595 r) {
this = r;
}


public static bool operator == (RC_e7b4e13946d568a48ef39b6a3bfce595 a, RC_e7b4e13946d568a48ef39b6a3bfce595 b) {
if (a.ssENInvoiceExtendedItemTax != b.ssENInvoiceExtendedItemTax) return false;
return true;
}

public static bool operator != (RC_e7b4e13946d568a48ef39b6a3bfce595 a, RC_e7b4e13946d568a48ef39b6a3bfce595 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e7b4e13946d568a48ef39b6a3bfce595)) return false;
return (this == (RC_e7b4e13946d568a48ef39b6a3bfce595)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedItemTax.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedItemTax.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedItemTax.InternalRecursiveSave();
}


public RC_e7b4e13946d568a48ef39b6a3bfce595 Duplicate() {
RC_e7b4e13946d568a48ef39b6a3bfce595 t;
t.ssENInvoiceExtendedItemTax = (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord)this.ssENInvoiceExtendedItemTax.Duplicate();
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
if (head == "invoiceextendeditemtax") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedItemTax")) variable.Value = ssENInvoiceExtendedItemTax; else variable.Optimized = true;
variable.SetFieldName("invoiceextendeditemtax");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedItemTax.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedItemTax.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedItemTax) {
return ssENInvoiceExtendedItemTax;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedItemTax.Key.AsGuid) {
return ssENInvoiceExtendedItemTax;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedItemTax.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedItemTax));
}
} // RC_e7b4e13946d568a48ef39b6a3bfce595
/// <summary>
/// RecordList type <code>InvoiceExtendedItemTaxRecordList</code> that represents a record list of
///  <code>InvoiceExtendedItemTax</code>
/// </summary>
public partial class RL_5b975f6376260cc87a4dc39e570700ae : GenericRecordList<RC_e7b4e13946d568a48ef39b6a3bfce595>, IEnumerable, IEnumerator {

protected override RC_e7b4e13946d568a48ef39b6a3bfce595 GetElementDefaultValue() {
return new RC_e7b4e13946d568a48ef39b6a3bfce595();
}

public T[] ToArray<T>(Func<RC_e7b4e13946d568a48ef39b6a3bfce595, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5b975f6376260cc87a4dc39e570700ae recordList, Func<RC_e7b4e13946d568a48ef39b6a3bfce595, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5b975f6376260cc87a4dc39e570700ae(RC_e7b4e13946d568a48ef39b6a3bfce595[] array) {
  RL_5b975f6376260cc87a4dc39e570700ae result = new RL_5b975f6376260cc87a4dc39e570700ae();
result.InnerFromArray(array);
    return result;
}

public static RL_5b975f6376260cc87a4dc39e570700ae ToList<T>(T[] array, Func <T, RC_e7b4e13946d568a48ef39b6a3bfce595> converter) {
  RL_5b975f6376260cc87a4dc39e570700ae result = new RL_5b975f6376260cc87a4dc39e570700ae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5b975f6376260cc87a4dc39e570700ae FromRestList<T>(RestList<T> restList, Func <T, RC_e7b4e13946d568a48ef39b6a3bfce595> converter) {
  RL_5b975f6376260cc87a4dc39e570700ae result = new RL_5b975f6376260cc87a4dc39e570700ae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5b975f6376260cc87a4dc39e570700ae() : base() {
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
protected override OSList<RC_e7b4e13946d568a48ef39b6a3bfce595> NewList() {
return new RL_5b975f6376260cc87a4dc39e570700ae();
}


} // RL_5b975f6376260cc87a4dc39e570700ae
}

