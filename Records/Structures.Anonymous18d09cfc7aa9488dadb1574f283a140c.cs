namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (_JzQGKl6jUitsVdPKDoUDA)
///  <code>RC_655f10514459daf453e41f31c05184fc</code> that represent
/// s
///  <code>OrderStatusOrderApprovalOrderMainOrderDetailOrderApprovalLevelIsCurrentApproverSupplierUserSu
/// pplierRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderStatusOrderApprovalOrderMainOrderDetailOrderApprovalLevelIsCurrentApproverSupplierUserSupplierRecord
public partial struct RC_655f10514459daf453e41f31c05184fc : ITypedRecord<RC_655f10514459daf453e41f31c05184fc> {
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdIsCurrentApprover = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4K9oADUdbruWynH+Qe60tQ");
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public bool ssIsCurrentApprover;

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_655f10514459daf453e41f31c05184fc() {
OptimizedAttributes = null;
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssIsCurrentApprover = false;
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(39,false);
    all[4] = new BitArray(17,false);
    all[5] = new BitArray(15,false);
    all[6] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENOrderStatus.OptimizedAttributes = value[0];
    ssENOrderApproval.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENOrderDetail.OptimizedAttributes = value[3];
    ssENOrderApprovalLevel.OptimizedAttributes = value[4];
    ssENSupplierUser.OptimizedAttributes = value[5];
    ssENSupplier.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENOrderStatus.OptimizedAttributes;
    all[1] = ssENOrderApproval.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENOrderDetail.OptimizedAttributes;
    all[4] = ssENOrderApprovalLevel.OptimizedAttributes;
    all[5] = ssENSupplierUser.OptimizedAttributes;
    all[6] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderStatus.Read( r, ref index);
ssENOrderApproval.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
ssIsCurrentApprover = r.ReadBoolean(index++, "OrderStatusOrderApprovalOrderMainOrderDetailOrderApprovalLevelIsCurrentApproverSupplierUserSupplierRecord.IsCurrentApprover", false);
ssENSupplierUser.Read( r, ref index);
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
public void ReadIM(RC_655f10514459daf453e41f31c05184fc r) {
this = r;
}


public static bool operator == (RC_655f10514459daf453e41f31c05184fc a, RC_655f10514459daf453e41f31c05184fc b) {
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssIsCurrentApprover != b.ssIsCurrentApprover) return false;
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_655f10514459daf453e41f31c05184fc a, RC_655f10514459daf453e41f31c05184fc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_655f10514459daf453e41f31c05184fc)) return false;
return (this == (RC_655f10514459daf453e41f31c05184fc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssIsCurrentApprover.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderStatus.RecursiveReset();
ssENOrderApproval.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssENSupplierUser.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderStatus.InternalRecursiveSave();
ssENOrderApproval.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssENSupplierUser.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_655f10514459daf453e41f31c05184fc Duplicate() {
RC_655f10514459daf453e41f31c05184fc t;
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
t.ssIsCurrentApprover = this.ssIsCurrentApprover;
t.ssENSupplierUser = (EN_360367a38fba8439556dd1e5826e0428EntityRecord)this.ssENSupplierUser.Duplicate();
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
if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssENOrderStatus; else variable.Optimized = true;
variable.SetFieldName("orderstatus");
} else if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
} else if (head == "iscurrentapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCurrentApprover")) variable.Value = ssIsCurrentApprover; else variable.Optimized = true;
} else if (head == "supplieruser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierUser")) variable.Value = ssENSupplierUser; else variable.Optimized = true;
variable.SetFieldName("supplieruser");
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
if (key == IdOrderStatus) {
return ssENOrderStatus;
}
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
if (key == IdIsCurrentApprover) {
return ssIsCurrentApprover;
}
if (key == IdSupplierUser) {
return ssENSupplierUser;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
if (attributeKey == IdIsCurrentApprover.Key.AsGuid) {
return ssIsCurrentApprover;
}
if (attributeKey == IdSupplierUser.Key.AsGuid) {
return ssENSupplierUser;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssIsCurrentApprover = (bool) other.AttributeGet(IdIsCurrentApprover);
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_655f10514459daf453e41f31c05184fc
/// <summary>
/// RecordList type
///  <code>OrderStatusOrderApprovalOrderMainOrderDetailOrderApprovalLevelIsCurrentApproverSupplierUserSu
/// pplierRecordList</code> that represents a record list of <code>OrderStatus, OrderApproval,
///  OrderMain, OrderDetail, OrderApprovalLevel, Boolean, SupplierUser, Supplier</code>
/// </summary>
public partial class RL_c5285652b7692ee7ff416f77dcd1fe1c : GenericRecordList<RC_655f10514459daf453e41f31c05184fc>, IEnumerable, IEnumerator {

protected override RC_655f10514459daf453e41f31c05184fc GetElementDefaultValue() {
return new RC_655f10514459daf453e41f31c05184fc();
}

public T[] ToArray<T>(Func<RC_655f10514459daf453e41f31c05184fc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c5285652b7692ee7ff416f77dcd1fe1c recordList, Func<RC_655f10514459daf453e41f31c05184fc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c5285652b7692ee7ff416f77dcd1fe1c(RC_655f10514459daf453e41f31c05184fc[] array) {
  RL_c5285652b7692ee7ff416f77dcd1fe1c result = new RL_c5285652b7692ee7ff416f77dcd1fe1c();
result.InnerFromArray(array);
    return result;
}

public static RL_c5285652b7692ee7ff416f77dcd1fe1c ToList<T>(T[] array, Func <T, RC_655f10514459daf453e41f31c05184fc> converter) {
  RL_c5285652b7692ee7ff416f77dcd1fe1c result = new RL_c5285652b7692ee7ff416f77dcd1fe1c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c5285652b7692ee7ff416f77dcd1fe1c FromRestList<T>(RestList<T> restList, Func <T, RC_655f10514459daf453e41f31c05184fc> converter) {
  RL_c5285652b7692ee7ff416f77dcd1fe1c result = new RL_c5285652b7692ee7ff416f77dcd1fe1c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c5285652b7692ee7ff416f77dcd1fe1c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(6,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(39,false);
def[4] = new BitArray(17,false);
def[5] = new BitArray(15,false);
def[6] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_655f10514459daf453e41f31c05184fc> NewList() {
return new RL_c5285652b7692ee7ff416f77dcd1fe1c();
}


} // RL_c5285652b7692ee7ff416f77dcd1fe1c
}

