namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (a608kbo23kSJtn4Cq1y6GA)
///  <code>RC_dd31a6c81d63b4e265f3c3d56e3eabb8</code> that represent
/// s <code>InvoiceOrderMainInvoiceAccountingProcessCompanySupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceOrderMainInvoiceAccountingProcessCompanySupplierRecord
public partial struct RC_dd31a6c81d63b4e265f3c3d56e3eabb8 : ITypedRecord<RC_dd31a6c81d63b4e265f3c3d56e3eabb8> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_dd31a6c81d63b4e265f3c3d56e3eabb8() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(9,false);
    all[3] = new BitArray(11,false);
    all[4] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[2];
    ssENCompany.OptimizedAttributes = value[3];
    ssENSupplier.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENInvoiceAccountingProcess.OptimizedAttributes;
    all[3] = ssENCompany.OptimizedAttributes;
    all[4] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENInvoiceAccountingProcess.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_dd31a6c81d63b4e265f3c3d56e3eabb8 r) {
this = r;
}


public static bool operator == (RC_dd31a6c81d63b4e265f3c3d56e3eabb8 a, RC_dd31a6c81d63b4e265f3c3d56e3eabb8 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_dd31a6c81d63b4e265f3c3d56e3eabb8 a, RC_dd31a6c81d63b4e265f3c3d56e3eabb8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dd31a6c81d63b4e265f3c3d56e3eabb8)) return false;
return (this == (RC_dd31a6c81d63b4e265f3c3d56e3eabb8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENInvoiceAccountingProcess.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENInvoiceAccountingProcess.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_dd31a6c81d63b4e265f3c3d56e3eabb8 Duplicate() {
RC_dd31a6c81d63b4e265f3c3d56e3eabb8 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENInvoiceAccountingProcess = (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord)this.ssENInvoiceAccountingProcess.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "invoiceaccountingprocess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcess")) variable.Value = ssENInvoiceAccountingProcess; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocess");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdInvoiceAccountingProcess) {
return ssENInvoiceAccountingProcess;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdInvoiceAccountingProcess.Key.AsGuid) {
return ssENInvoiceAccountingProcess;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_dd31a6c81d63b4e265f3c3d56e3eabb8
/// <summary>
/// RecordList type <code>InvoiceOrderMainInvoiceAccountingProcessCompanySupplierRecordList</code> that
///  represents a record list of <code>Invoice, OrderMain, InvoiceAccountingProcess, Company
/// , Supplier</code>
/// </summary>
public partial class RL_079c863bfa7218132c4b01aab39a9575 : GenericRecordList<RC_dd31a6c81d63b4e265f3c3d56e3eabb8>, IEnumerable, IEnumerator {

protected override RC_dd31a6c81d63b4e265f3c3d56e3eabb8 GetElementDefaultValue() {
return new RC_dd31a6c81d63b4e265f3c3d56e3eabb8();
}

public T[] ToArray<T>(Func<RC_dd31a6c81d63b4e265f3c3d56e3eabb8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_079c863bfa7218132c4b01aab39a9575 recordList, Func<RC_dd31a6c81d63b4e265f3c3d56e3eabb8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_079c863bfa7218132c4b01aab39a9575(RC_dd31a6c81d63b4e265f3c3d56e3eabb8[] array) {
  RL_079c863bfa7218132c4b01aab39a9575 result = new RL_079c863bfa7218132c4b01aab39a9575();
result.InnerFromArray(array);
    return result;
}

public static RL_079c863bfa7218132c4b01aab39a9575 ToList<T>(T[] array, Func <T, RC_dd31a6c81d63b4e265f3c3d56e3eabb8> converter) {
  RL_079c863bfa7218132c4b01aab39a9575 result = new RL_079c863bfa7218132c4b01aab39a9575();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_079c863bfa7218132c4b01aab39a9575 FromRestList<T>(RestList<T> restList, Func <T, RC_dd31a6c81d63b4e265f3c3d56e3eabb8> converter) {
  RL_079c863bfa7218132c4b01aab39a9575 result = new RL_079c863bfa7218132c4b01aab39a9575();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_079c863bfa7218132c4b01aab39a9575() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(24,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(9,false);
def[3] = new BitArray(11,false);
def[4] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_dd31a6c81d63b4e265f3c3d56e3eabb8> NewList() {
return new RL_079c863bfa7218132c4b01aab39a9575();
}


} // RL_079c863bfa7218132c4b01aab39a9575
}

