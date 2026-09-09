namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pLSqDE4GmEO7KY9FmfabeA)
///  <code>RC_60aeadfeb5acbf1f5997b0af030c3433</code> that represent
/// s
///  <code>InvoiceFolioRequisitionOrderMainInvoicePolizaFolioSocietyOrderSocietyReqSocietyRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceFolioRequisitionOrderMainInvoicePolizaFolioSocietyOrderSocietyReqSocietyRecord
public partial struct RC_60aeadfeb5acbf1f5997b0af030c3433 : ITypedRecord<RC_60aeadfeb5acbf1f5997b0af030c3433> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdInvoicePoliza = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FGf9FFyQZ8GAODzC2obuDQ");
internal static readonly GlobalObjectKey IdFolioSociety = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RHJxDfR0FIukl+1vOSZ+jA");
internal static readonly GlobalObjectKey IdOrderSociety = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7f3R2bPan8I8b3lXagdmRQ");
internal static readonly GlobalObjectKey IdReqSociety = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*W3AR3kgjpJkZyTrx+Jzxlw");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord ssENInvoicePoliza;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENFolioSociety;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENOrderSociety;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENReqSociety;


public BitArray OptimizedAttributes;

public RC_60aeadfeb5acbf1f5997b0af030c3433() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENInvoicePoliza = new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord();
ssENFolioSociety = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENOrderSociety = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENReqSociety = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(29,false);
    all[4] = new BitArray(9,false);
    all[5] = new BitArray(11,false);
    all[6] = new BitArray(11,false);
    all[7] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoicePoliza.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENFolioSociety.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENOrderSociety.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENReqSociety.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENOrderMain.OptimizedAttributes = value[3];
    ssENInvoicePoliza.OptimizedAttributes = value[4];
    ssENFolioSociety.OptimizedAttributes = value[5];
    ssENOrderSociety.OptimizedAttributes = value[6];
    ssENReqSociety.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENOrderMain.OptimizedAttributes;
    all[4] = ssENInvoicePoliza.OptimizedAttributes;
    all[5] = ssENFolioSociety.OptimizedAttributes;
    all[6] = ssENOrderSociety.OptimizedAttributes;
    all[7] = ssENReqSociety.OptimizedAttributes;
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
ssENFolio.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENInvoicePoliza.Read( r, ref index);
ssENFolioSociety.Read( r, ref index);
ssENOrderSociety.Read( r, ref index);
ssENReqSociety.Read( r, ref index);
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
public void ReadIM(RC_60aeadfeb5acbf1f5997b0af030c3433 r) {
this = r;
}


public static bool operator == (RC_60aeadfeb5acbf1f5997b0af030c3433 a, RC_60aeadfeb5acbf1f5997b0af030c3433 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENInvoicePoliza != b.ssENInvoicePoliza) return false;
if (a.ssENFolioSociety != b.ssENFolioSociety) return false;
if (a.ssENOrderSociety != b.ssENOrderSociety) return false;
if (a.ssENReqSociety != b.ssENReqSociety) return false;
return true;
}

public static bool operator != (RC_60aeadfeb5acbf1f5997b0af030c3433 a, RC_60aeadfeb5acbf1f5997b0af030c3433 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_60aeadfeb5acbf1f5997b0af030c3433)) return false;
return (this == (RC_60aeadfeb5acbf1f5997b0af030c3433)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENInvoicePoliza.GetHashCode()
 ^ ssENFolioSociety.GetHashCode()
 ^ ssENOrderSociety.GetHashCode()
 ^ ssENReqSociety.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENInvoicePoliza.RecursiveReset();
ssENFolioSociety.RecursiveReset();
ssENOrderSociety.RecursiveReset();
ssENReqSociety.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENInvoicePoliza.InternalRecursiveSave();
ssENFolioSociety.InternalRecursiveSave();
ssENOrderSociety.InternalRecursiveSave();
ssENReqSociety.InternalRecursiveSave();
}


public RC_60aeadfeb5acbf1f5997b0af030c3433 Duplicate() {
RC_60aeadfeb5acbf1f5997b0af030c3433 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENInvoicePoliza = (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord)this.ssENInvoicePoliza.Duplicate();
t.ssENFolioSociety = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENFolioSociety.Duplicate();
t.ssENOrderSociety = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENOrderSociety.Duplicate();
t.ssENReqSociety = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENReqSociety.Duplicate();
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
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "invoicepoliza") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicePoliza")) variable.Value = ssENInvoicePoliza; else variable.Optimized = true;
variable.SetFieldName("invoicepoliza");
} else if (head == "foliosociety") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioSociety")) variable.Value = ssENFolioSociety; else variable.Optimized = true;
variable.SetFieldName("foliosociety");
} else if (head == "ordersociety") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderSociety")) variable.Value = ssENOrderSociety; else variable.Optimized = true;
variable.SetFieldName("ordersociety");
} else if (head == "reqsociety") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ReqSociety")) variable.Value = ssENReqSociety; else variable.Optimized = true;
variable.SetFieldName("reqsociety");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdInvoicePoliza) {
return ssENInvoicePoliza;
}
if (key == IdFolioSociety) {
return ssENFolioSociety;
}
if (key == IdOrderSociety) {
return ssENOrderSociety;
}
if (key == IdReqSociety) {
return ssENReqSociety;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdInvoicePoliza.Key.AsGuid) {
return ssENInvoicePoliza;
}
if (attributeKey == IdFolioSociety.Key.AsGuid) {
return ssENFolioSociety;
}
if (attributeKey == IdOrderSociety.Key.AsGuid) {
return ssENOrderSociety;
}
if (attributeKey == IdReqSociety.Key.AsGuid) {
return ssENReqSociety;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENInvoicePoliza.FillFromOther((IRecord) other.AttributeGet(IdInvoicePoliza));
ssENFolioSociety.FillFromOther((IRecord) other.AttributeGet(IdFolioSociety));
ssENOrderSociety.FillFromOther((IRecord) other.AttributeGet(IdOrderSociety));
ssENReqSociety.FillFromOther((IRecord) other.AttributeGet(IdReqSociety));
}
} // RC_60aeadfeb5acbf1f5997b0af030c3433
/// <summary>
/// RecordList type
///  <code>InvoiceFolioRequisitionOrderMainInvoicePolizaFolioSocietyOrderSocietyReqSocietyRecordList</co
/// de> that represents a record list of <code>Invoice, Folio, Requisition, OrderMain, InvoicePoliza,
///  Company, Company, Company</code>
/// </summary>
public partial class RL_031b891075d450fa5dc6dea0047d0fa4 : GenericRecordList<RC_60aeadfeb5acbf1f5997b0af030c3433>, IEnumerable, IEnumerator {

protected override RC_60aeadfeb5acbf1f5997b0af030c3433 GetElementDefaultValue() {
return new RC_60aeadfeb5acbf1f5997b0af030c3433();
}

public T[] ToArray<T>(Func<RC_60aeadfeb5acbf1f5997b0af030c3433, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_031b891075d450fa5dc6dea0047d0fa4 recordList, Func<RC_60aeadfeb5acbf1f5997b0af030c3433, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_031b891075d450fa5dc6dea0047d0fa4(RC_60aeadfeb5acbf1f5997b0af030c3433[] array) {
  RL_031b891075d450fa5dc6dea0047d0fa4 result = new RL_031b891075d450fa5dc6dea0047d0fa4();
result.InnerFromArray(array);
    return result;
}

public static RL_031b891075d450fa5dc6dea0047d0fa4 ToList<T>(T[] array, Func <T, RC_60aeadfeb5acbf1f5997b0af030c3433> converter) {
  RL_031b891075d450fa5dc6dea0047d0fa4 result = new RL_031b891075d450fa5dc6dea0047d0fa4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_031b891075d450fa5dc6dea0047d0fa4 FromRestList<T>(RestList<T> restList, Func <T, RC_60aeadfeb5acbf1f5997b0af030c3433> converter) {
  RL_031b891075d450fa5dc6dea0047d0fa4 result = new RL_031b891075d450fa5dc6dea0047d0fa4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_031b891075d450fa5dc6dea0047d0fa4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(24,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(29,false);
def[4] = new BitArray(9,false);
def[5] = new BitArray(11,false);
def[6] = new BitArray(11,false);
def[7] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_60aeadfeb5acbf1f5997b0af030c3433> NewList() {
return new RL_031b891075d450fa5dc6dea0047d0fa4();
}


} // RL_031b891075d450fa5dc6dea0047d0fa4
}

