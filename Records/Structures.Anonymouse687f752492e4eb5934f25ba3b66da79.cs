namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (UveH5i5JtU6TTyW6O2baeQ)
///  <code>RC_f049d8b2272822e744e04ef94d71a8ef</code> that represent
/// s <code>FolioOrderCostCenterOrderAccountingOrderMainOrderDetailSupplierRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: FolioOrderCostCenterOrderAccountingOrderMainOrderDetailSupplierRegionRecord
public partial struct RC_f049d8b2272822e744e04ef94d71a8ef : ITypedRecord<RC_f049d8b2272822e744e04ef94d71a8ef> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderCostCenter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*v8RgVD+bV5ZqCOKa6WnL5w");
internal static readonly GlobalObjectKey IdOrderAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OM_CLcG8i2ozjcXqmlxkRg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord ssENOrderCostCenter;

public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_f049d8b2272822e744e04ef94d71a8ef() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderCostCenter = new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord();
ssENOrderAccounting = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(3,false);
    all[2] = new BitArray(19,false);
    all[3] = new BitArray(29,false);
    all[4] = new BitArray(39,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderCostCenter.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENOrderCostCenter.OptimizedAttributes = value[1];
    ssENOrderAccounting.OptimizedAttributes = value[2];
    ssENOrderMain.OptimizedAttributes = value[3];
    ssENOrderDetail.OptimizedAttributes = value[4];
    ssENSupplier.OptimizedAttributes = value[5];
    ssENRegion.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENOrderCostCenter.OptimizedAttributes;
    all[2] = ssENOrderAccounting.OptimizedAttributes;
    all[3] = ssENOrderMain.OptimizedAttributes;
    all[4] = ssENOrderDetail.OptimizedAttributes;
    all[5] = ssENSupplier.OptimizedAttributes;
    all[6] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolio.Read( r, ref index);
ssENOrderCostCenter.Read( r, ref index);
ssENOrderAccounting.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_f049d8b2272822e744e04ef94d71a8ef r) {
this = r;
}


public static bool operator == (RC_f049d8b2272822e744e04ef94d71a8ef a, RC_f049d8b2272822e744e04ef94d71a8ef b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderCostCenter != b.ssENOrderCostCenter) return false;
if (a.ssENOrderAccounting != b.ssENOrderAccounting) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_f049d8b2272822e744e04ef94d71a8ef a, RC_f049d8b2272822e744e04ef94d71a8ef b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f049d8b2272822e744e04ef94d71a8ef)) return false;
return (this == (RC_f049d8b2272822e744e04ef94d71a8ef)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderCostCenter.GetHashCode()
 ^ ssENOrderAccounting.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENOrderCostCenter.RecursiveReset();
ssENOrderAccounting.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENOrderCostCenter.InternalRecursiveSave();
ssENOrderAccounting.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_f049d8b2272822e744e04ef94d71a8ef Duplicate() {
RC_f049d8b2272822e744e04ef94d71a8ef t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderCostCenter = (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord)this.ssENOrderCostCenter.Duplicate();
t.ssENOrderAccounting = (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)this.ssENOrderAccounting.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordercostcenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderCostCenter")) variable.Value = ssENOrderCostCenter; else variable.Optimized = true;
variable.SetFieldName("ordercostcenter");
} else if (head == "orderaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccounting")) variable.Value = ssENOrderAccounting; else variable.Optimized = true;
variable.SetFieldName("orderaccounting");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderCostCenter) {
return ssENOrderCostCenter;
}
if (key == IdOrderAccounting) {
return ssENOrderAccounting;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderCostCenter.Key.AsGuid) {
return ssENOrderCostCenter;
}
if (attributeKey == IdOrderAccounting.Key.AsGuid) {
return ssENOrderAccounting;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderCostCenter.FillFromOther((IRecord) other.AttributeGet(IdOrderCostCenter));
ssENOrderAccounting.FillFromOther((IRecord) other.AttributeGet(IdOrderAccounting));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_f049d8b2272822e744e04ef94d71a8ef
/// <summary>
/// RecordList type
///  <code>FolioOrderCostCenterOrderAccountingOrderMainOrderDetailSupplierRegionRecordList</code> tha
/// t represents a record list of <code>Folio, OrderCostCenter, OrderAccounting, OrderMain,
///  OrderDetail, Supplier, Region</code>
/// </summary>
public partial class RL_66bb1349260f72f9d01bbe22c0aaf421 : GenericRecordList<RC_f049d8b2272822e744e04ef94d71a8ef>, IEnumerable, IEnumerator {

protected override RC_f049d8b2272822e744e04ef94d71a8ef GetElementDefaultValue() {
return new RC_f049d8b2272822e744e04ef94d71a8ef();
}

public T[] ToArray<T>(Func<RC_f049d8b2272822e744e04ef94d71a8ef, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_66bb1349260f72f9d01bbe22c0aaf421 recordList, Func<RC_f049d8b2272822e744e04ef94d71a8ef, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_66bb1349260f72f9d01bbe22c0aaf421(RC_f049d8b2272822e744e04ef94d71a8ef[] array) {
  RL_66bb1349260f72f9d01bbe22c0aaf421 result = new RL_66bb1349260f72f9d01bbe22c0aaf421();
result.InnerFromArray(array);
    return result;
}

public static RL_66bb1349260f72f9d01bbe22c0aaf421 ToList<T>(T[] array, Func <T, RC_f049d8b2272822e744e04ef94d71a8ef> converter) {
  RL_66bb1349260f72f9d01bbe22c0aaf421 result = new RL_66bb1349260f72f9d01bbe22c0aaf421();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_66bb1349260f72f9d01bbe22c0aaf421 FromRestList<T>(RestList<T> restList, Func <T, RC_f049d8b2272822e744e04ef94d71a8ef> converter) {
  RL_66bb1349260f72f9d01bbe22c0aaf421 result = new RL_66bb1349260f72f9d01bbe22c0aaf421();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_66bb1349260f72f9d01bbe22c0aaf421() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(20,false);
def[1] = new BitArray(3,false);
def[2] = new BitArray(19,false);
def[3] = new BitArray(29,false);
def[4] = new BitArray(39,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f049d8b2272822e744e04ef94d71a8ef> NewList() {
return new RL_66bb1349260f72f9d01bbe22c0aaf421();
}


} // RL_66bb1349260f72f9d01bbe22c0aaf421
}

