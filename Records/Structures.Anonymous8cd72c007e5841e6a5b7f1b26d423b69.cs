namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ACzXjFh+5kGlt_GybUI7aQ)
///  <code>RC_4dd2c54294876907ff3203d83c5ad25d</code> that represent
/// s
///  <code>AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameR
/// ecord</code> <p>Description: </p>
/// </summary>
// Name: AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord
public partial struct RC_4dd2c54294876907ff3203d83c5ad25d : ITypedRecord<RC_4dd2c54294876907ff3203d83c5ad25d> {
internal static readonly GlobalObjectKey IdAccount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*j941kKcwEgXlMw5fFAyZ3g");
internal static readonly GlobalObjectKey IdAmountMD = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XBlEacL31wLrPM1TP6Pe5Q");
internal static readonly GlobalObjectKey IdAmountML = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S5IGqdCGiiri1sp99n8Gjg");
internal static readonly GlobalObjectKey IdComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gbjDZfy8rltpuBwoj7rJJw");
internal static readonly GlobalObjectKey IdCurrencyMD = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WOrfGikz0YGcwRzT2pzDLA");
internal static readonly GlobalObjectKey IdCurrencyML = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*i0VqAWLH41oVFsONNFkZSQ");
internal static readonly GlobalObjectKey IdNumDoc = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*igo0xH0LOIxo+W54ngV2FA");
internal static readonly GlobalObjectKey IdRef = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*twoIZwQfNS7NlUR2pLrRvQ");
internal static readonly GlobalObjectKey IdRegionName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*v4XKDbXbgi2_whLoL04tsQ");
internal static readonly GlobalObjectKey IdSocietyName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xq00xVMHjRAVcbQfO9KK+Q");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*psx6qOaBMsmupfdZ57vTTA");

public string ssAccount;

public string ssAmountMD;

public string ssAmountML;

public string ssComment;

public string ssCurrencyMD;

public string ssCurrencyML;

public string ssNumDoc;

public string ssRef;

public string ssRegionName;

public string ssSocietyName;

public string ssSupplierName;


public BitArray OptimizedAttributes;

public RC_4dd2c54294876907ff3203d83c5ad25d() {
OptimizedAttributes = null;
ssAccount = "";
ssAmountMD = "";
ssAmountML = "";
ssComment = "";
ssCurrencyMD = "";
ssCurrencyML = "";
ssNumDoc = "";
ssRef = "";
ssRegionName = "";
ssSocietyName = "";
ssSupplierName = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssAccount = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.Account", "");
ssAmountMD = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.AmountMD", "");
ssAmountML = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.AmountML", "");
ssComment = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.Comment", "");
ssCurrencyMD = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.CurrencyMD", "");
ssCurrencyML = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.CurrencyML", "");
ssNumDoc = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.NumDoc", "");
ssRef = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.Ref", "");
ssRegionName = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.RegionName", "");
ssSocietyName = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.SocietyName", "");
ssSupplierName = r.ReadText(index++, "AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord.SupplierName", "");
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
public void ReadIM(RC_4dd2c54294876907ff3203d83c5ad25d r) {
this = r;
}


public static bool operator == (RC_4dd2c54294876907ff3203d83c5ad25d a, RC_4dd2c54294876907ff3203d83c5ad25d b) {
if (a.ssAccount != b.ssAccount) return false;
if (a.ssAmountMD != b.ssAmountMD) return false;
if (a.ssAmountML != b.ssAmountML) return false;
if (a.ssComment != b.ssComment) return false;
if (a.ssCurrencyMD != b.ssCurrencyMD) return false;
if (a.ssCurrencyML != b.ssCurrencyML) return false;
if (a.ssNumDoc != b.ssNumDoc) return false;
if (a.ssRef != b.ssRef) return false;
if (a.ssRegionName != b.ssRegionName) return false;
if (a.ssSocietyName != b.ssSocietyName) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
return true;
}

public static bool operator != (RC_4dd2c54294876907ff3203d83c5ad25d a, RC_4dd2c54294876907ff3203d83c5ad25d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4dd2c54294876907ff3203d83c5ad25d)) return false;
return (this == (RC_4dd2c54294876907ff3203d83c5ad25d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAccount.GetHashCode()
 ^ ssAmountMD.GetHashCode()
 ^ ssAmountML.GetHashCode()
 ^ ssComment.GetHashCode()
 ^ ssCurrencyMD.GetHashCode()
 ^ ssCurrencyML.GetHashCode()
 ^ ssNumDoc.GetHashCode()
 ^ ssRef.GetHashCode()
 ^ ssRegionName.GetHashCode()
 ^ ssSocietyName.GetHashCode()
 ^ ssSupplierName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_4dd2c54294876907ff3203d83c5ad25d Duplicate() {
RC_4dd2c54294876907ff3203d83c5ad25d t;
t.ssAccount = this.ssAccount;
t.ssAmountMD = this.ssAmountMD;
t.ssAmountML = this.ssAmountML;
t.ssComment = this.ssComment;
t.ssCurrencyMD = this.ssCurrencyMD;
t.ssCurrencyML = this.ssCurrencyML;
t.ssNumDoc = this.ssNumDoc;
t.ssRef = this.ssRef;
t.ssRegionName = this.ssRegionName;
t.ssSocietyName = this.ssSocietyName;
t.ssSupplierName = this.ssSupplierName;
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
if (head == "account") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Account")) variable.Value = ssAccount; else variable.Optimized = true;
} else if (head == "amountmd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AmountMD")) variable.Value = ssAmountMD; else variable.Optimized = true;
} else if (head == "amountml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AmountML")) variable.Value = ssAmountML; else variable.Optimized = true;
} else if (head == "comment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Comment")) variable.Value = ssComment; else variable.Optimized = true;
} else if (head == "currencymd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyMD")) variable.Value = ssCurrencyMD; else variable.Optimized = true;
} else if (head == "currencyml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyML")) variable.Value = ssCurrencyML; else variable.Optimized = true;
} else if (head == "numdoc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NumDoc")) variable.Value = ssNumDoc; else variable.Optimized = true;
} else if (head == "ref") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ref")) variable.Value = ssRef; else variable.Optimized = true;
} else if (head == "regionname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionName")) variable.Value = ssRegionName; else variable.Optimized = true;
} else if (head == "societyname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SocietyName")) variable.Value = ssSocietyName; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
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
if (key == IdAccount) {
return ssAccount;
}
if (key == IdAmountMD) {
return ssAmountMD;
}
if (key == IdAmountML) {
return ssAmountML;
}
if (key == IdComment) {
return ssComment;
}
if (key == IdCurrencyMD) {
return ssCurrencyMD;
}
if (key == IdCurrencyML) {
return ssCurrencyML;
}
if (key == IdNumDoc) {
return ssNumDoc;
}
if (key == IdRef) {
return ssRef;
}
if (key == IdRegionName) {
return ssRegionName;
}
if (key == IdSocietyName) {
return ssSocietyName;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccount.Key.AsGuid) {
return ssAccount;
}
if (attributeKey == IdAmountMD.Key.AsGuid) {
return ssAmountMD;
}
if (attributeKey == IdAmountML.Key.AsGuid) {
return ssAmountML;
}
if (attributeKey == IdComment.Key.AsGuid) {
return ssComment;
}
if (attributeKey == IdCurrencyMD.Key.AsGuid) {
return ssCurrencyMD;
}
if (attributeKey == IdCurrencyML.Key.AsGuid) {
return ssCurrencyML;
}
if (attributeKey == IdNumDoc.Key.AsGuid) {
return ssNumDoc;
}
if (attributeKey == IdRef.Key.AsGuid) {
return ssRef;
}
if (attributeKey == IdRegionName.Key.AsGuid) {
return ssRegionName;
}
if (attributeKey == IdSocietyName.Key.AsGuid) {
return ssSocietyName;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAccount = (string) other.AttributeGet(IdAccount);
ssAmountMD = (string) other.AttributeGet(IdAmountMD);
ssAmountML = (string) other.AttributeGet(IdAmountML);
ssComment = (string) other.AttributeGet(IdComment);
ssCurrencyMD = (string) other.AttributeGet(IdCurrencyMD);
ssCurrencyML = (string) other.AttributeGet(IdCurrencyML);
ssNumDoc = (string) other.AttributeGet(IdNumDoc);
ssRef = (string) other.AttributeGet(IdRef);
ssRegionName = (string) other.AttributeGet(IdRegionName);
ssSocietyName = (string) other.AttributeGet(IdSocietyName);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
}
} // RC_4dd2c54294876907ff3203d83c5ad25d
/// <summary>
/// RecordList type
///  <code>AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameR
/// ecordList</code> that represents a record list of <code>Text, Text, Text, Text, Text, Text, Text,
///  Text, Text, Text, Text</code>
/// </summary>
public partial class RL_3de40603ae6c869db08c8514af3a6489 : GenericRecordList<RC_4dd2c54294876907ff3203d83c5ad25d>, IEnumerable, IEnumerator {

protected override RC_4dd2c54294876907ff3203d83c5ad25d GetElementDefaultValue() {
return new RC_4dd2c54294876907ff3203d83c5ad25d();
}

public T[] ToArray<T>(Func<RC_4dd2c54294876907ff3203d83c5ad25d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3de40603ae6c869db08c8514af3a6489 recordList, Func<RC_4dd2c54294876907ff3203d83c5ad25d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3de40603ae6c869db08c8514af3a6489(RC_4dd2c54294876907ff3203d83c5ad25d[] array) {
  RL_3de40603ae6c869db08c8514af3a6489 result = new RL_3de40603ae6c869db08c8514af3a6489();
result.InnerFromArray(array);
    return result;
}

public static RL_3de40603ae6c869db08c8514af3a6489 ToList<T>(T[] array, Func <T, RC_4dd2c54294876907ff3203d83c5ad25d> converter) {
  RL_3de40603ae6c869db08c8514af3a6489 result = new RL_3de40603ae6c869db08c8514af3a6489();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3de40603ae6c869db08c8514af3a6489 FromRestList<T>(RestList<T> restList, Func <T, RC_4dd2c54294876907ff3203d83c5ad25d> converter) {
  RL_3de40603ae6c869db08c8514af3a6489 result = new RL_3de40603ae6c869db08c8514af3a6489();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3de40603ae6c869db08c8514af3a6489() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4dd2c54294876907ff3203d83c5ad25d> NewList() {
return new RL_3de40603ae6c869db08c8514af3a6489();
}


} // RL_3de40603ae6c869db08c8514af3a6489
}

