namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (h22S4LRmp0K5FZDOk6fu2w)
///  <code>RC_ce1213db14f29aa4f95120ea7ad7d0b7</code> that represent
/// s <code>InvoiceExtendedItemInvoiceExtendedItemTaxListRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedItemInvoiceExtendedItemTaxListRecord
public partial struct RC_ce1213db14f29aa4f95120ea7ad7d0b7 : ITypedRecord<RC_ce1213db14f29aa4f95120ea7ad7d0b7> {
internal static readonly GlobalObjectKey IdInvoiceExtendedItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zxAmf18M2K1rp4yQLDHv+g");
internal static readonly GlobalObjectKey IdInvoiceExtendedItemTaxList = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OdJYdsxrQU+tPBJB31xkfg");

public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ssENInvoiceExtendedItem;

public RL_052a618537841aabfe590fb1dffa78ab ssRLInvoiceExtendedItemTaxList;


public BitArray OptimizedAttributes;

public RC_ce1213db14f29aa4f95120ea7ad7d0b7() {
OptimizedAttributes = null;
ssENInvoiceExtendedItem = new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord();
ssRLInvoiceExtendedItemTaxList = new RL_052a618537841aabfe590fb1dffa78ab();
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
public void ReadIM(RC_ce1213db14f29aa4f95120ea7ad7d0b7 r) {
this = r;
}


public static bool operator == (RC_ce1213db14f29aa4f95120ea7ad7d0b7 a, RC_ce1213db14f29aa4f95120ea7ad7d0b7 b) {
if (a.ssENInvoiceExtendedItem != b.ssENInvoiceExtendedItem) return false;
if (a.ssRLInvoiceExtendedItemTaxList != b.ssRLInvoiceExtendedItemTaxList) return false;
return true;
}

public static bool operator != (RC_ce1213db14f29aa4f95120ea7ad7d0b7 a, RC_ce1213db14f29aa4f95120ea7ad7d0b7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ce1213db14f29aa4f95120ea7ad7d0b7)) return false;
return (this == (RC_ce1213db14f29aa4f95120ea7ad7d0b7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedItem.GetHashCode()
 ^ ssRLInvoiceExtendedItemTaxList.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedItem.RecursiveReset();
ssRLInvoiceExtendedItemTaxList.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedItem.InternalRecursiveSave();
ssRLInvoiceExtendedItemTaxList.InternalRecursiveSave();
}


public RC_ce1213db14f29aa4f95120ea7ad7d0b7 Duplicate() {
RC_ce1213db14f29aa4f95120ea7ad7d0b7 t;
t.ssENInvoiceExtendedItem = (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord)this.ssENInvoiceExtendedItem.Duplicate();
t.ssRLInvoiceExtendedItemTaxList = (RL_052a618537841aabfe590fb1dffa78ab)this.ssRLInvoiceExtendedItemTaxList.Duplicate();
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
} else if (head == "invoiceextendeditemtaxlist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedItemTaxList")) variable.Value = ssRLInvoiceExtendedItemTaxList; else variable.Optimized = true;
variable.SetFieldName("invoiceextendeditemtaxlist");
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
if (key == IdInvoiceExtendedItem) {
return ssENInvoiceExtendedItem;
}
if (key == IdInvoiceExtendedItemTaxList) {
return ssRLInvoiceExtendedItemTaxList;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedItem.Key.AsGuid) {
return ssENInvoiceExtendedItem;
}
if (attributeKey == IdInvoiceExtendedItemTaxList.Key.AsGuid) {
return ssRLInvoiceExtendedItemTaxList;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedItem.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedItem));
ssRLInvoiceExtendedItemTaxList = new RL_052a618537841aabfe590fb1dffa78ab();
ssRLInvoiceExtendedItemTaxList.FillFromOther((IOSList) other.AttributeGet(IdInvoiceExtendedItemTaxList));
}
} // RC_ce1213db14f29aa4f95120ea7ad7d0b7
/// <summary>
/// RecordList type <code>InvoiceExtendedItemInvoiceExtendedItemTaxListRecordList</code> that
///  represents a record list of <code>InvoiceExtendedItem, InvoiceExtendedItemTaxList</code>
/// </summary>
public partial class RL_698fc6adea2f9e4df8f68df6dcd5ea9d : GenericRecordList<RC_ce1213db14f29aa4f95120ea7ad7d0b7>, IEnumerable, IEnumerator {

protected override RC_ce1213db14f29aa4f95120ea7ad7d0b7 GetElementDefaultValue() {
return new RC_ce1213db14f29aa4f95120ea7ad7d0b7();
}

public T[] ToArray<T>(Func<RC_ce1213db14f29aa4f95120ea7ad7d0b7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_698fc6adea2f9e4df8f68df6dcd5ea9d recordList, Func<RC_ce1213db14f29aa4f95120ea7ad7d0b7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_698fc6adea2f9e4df8f68df6dcd5ea9d(RC_ce1213db14f29aa4f95120ea7ad7d0b7[] array) {
  RL_698fc6adea2f9e4df8f68df6dcd5ea9d result = new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();
result.InnerFromArray(array);
    return result;
}

public static RL_698fc6adea2f9e4df8f68df6dcd5ea9d ToList<T>(T[] array, Func <T, RC_ce1213db14f29aa4f95120ea7ad7d0b7> converter) {
  RL_698fc6adea2f9e4df8f68df6dcd5ea9d result = new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_698fc6adea2f9e4df8f68df6dcd5ea9d FromRestList<T>(RestList<T> restList, Func <T, RC_ce1213db14f29aa4f95120ea7ad7d0b7> converter) {
  RL_698fc6adea2f9e4df8f68df6dcd5ea9d result = new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_698fc6adea2f9e4df8f68df6dcd5ea9d() : base() {
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
protected override OSList<RC_ce1213db14f29aa4f95120ea7ad7d0b7> NewList() {
return new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();
}


} // RL_698fc6adea2f9e4df8f68df6dcd5ea9d
}

